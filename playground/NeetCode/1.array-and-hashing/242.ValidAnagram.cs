namespace NeetCode.ArraysAndHashing;

public class P242
{
    public static void Run()
    {
        // string s = "anagram";
        // string t = "nagaram";
        //----------------------------
        string s = "aa";
        string t = "bb";
        var result = IsAnagram_1(s, t);
        Console.WriteLine(result);
    }

    public static bool IsAnagram_1(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();

        // Count characters in s
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))

                map[s[i]]++;
            else
                map[s[i]] = 1;
        }

        // Subtract characters in t
        foreach (var item in t)
        {
            if (!map.ContainsKey(item) || map[item] == 0)
                return false;
            map[item]--;
        }

        return true;
    }

    public static bool IsAnagram_2(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var sList = s.Order().ToArray();
        var tList = t.Order().ToArray();

        for (int i = 0; i < sList.Length; i++)
        {
            if (sList[i] != tList[i])
                return false;
        }
        return true;
    }

    public static bool IsAnagram_3(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var leftStr = s.Select(x => x).Order();
        var rightStr = t.Select(x => x).Order();

        return string.Join("", leftStr) == string.Join("", rightStr);
    }
}
