namespace NeetCode.ArraysAndHashing;

public class P49
{
    public static void Run()
    {
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

        var result = GroupAnagrams_1(strs);

        System.Console.WriteLine(result);
    }

    public static IList<IList<string>> GroupAnagrams_1(string[] strs)
    {
        var anagramMap = new Dictionary<string, IList<string>>();
        foreach (string s in strs)
        {
            char[] key = s.ToCharArray();
            Array.Sort(key);
            String keyStr = new String(key);
            if (anagramMap.ContainsKey(keyStr))
                anagramMap[keyStr].Add(s);
            else
                anagramMap[keyStr] = new List<string> { s };
        }
        return anagramMap.Values.ToList();
    }

    public static IList<IList<string>> GroupAnagrams_2(string[] strs)
    {
        //map of same anagrams
        var mapAnagrams = new Dictionary<string, List<int>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = string.Join("", strs[i].Order());
            if (!mapAnagrams.ContainsKey(str))
                mapAnagrams[str] = new List<int> { i };
            else
            {
                mapAnagrams[str].Add(i);
            }
        }
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var item in mapAnagrams)
        {
            var list = new List<string>();
            for (int i = 0; i < item.Value.Count; i++)
            {
                list.Add(strs[item.Value[i]]);
            }
            result.Add(list);
        }

        return result;
    }

    public static IList<IList<string>> GroupAnagrams_3(string[] strs)
    {
        List<string> sortedArr = new List<string>();
        foreach (string item in strs)
        {
            var sortedStr = string.Join("", item.Order());
            sortedArr.Add(sortedStr);
        }

        var dict = new Dictionary<string, List<int>>();

        for (int i = 0; i < sortedArr.Count; i++)
        {
            if (dict.ContainsKey(sortedArr[i]))
            {
                var sameWordAnagramsIndices = new List<int>();
                dict.TryGetValue(sortedArr[i], out sameWordAnagramsIndices);
                sameWordAnagramsIndices!.Add(i);
                dict[sortedArr[i]] = sameWordAnagramsIndices;
            }
            else
            {
                dict.Add(sortedArr[i], new List<int> { i });
            }
        }

        var result = new List<IList<string>>();
        foreach (var item in dict)
        {
            var tempList = new List<string>();

            foreach (var i in item.Value)
            {
                tempList.Add(strs[i]);
            }
            result.Add(tempList);
        }
        return result;
    }
}
