namespace NeetCode.ArraysAndHashing;

public class P4
{
    public static void Run()
    {
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

        var result = GroupAnagrams(strs);

        System.Console.WriteLine(result);
    }

    public static IList<IList<string>> GroupAnagrams(string[] strs)
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