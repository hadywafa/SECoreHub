namespace NeetCode.ArraysAndHashing;

public class P242
{
    public static void Run()
    {
        string s = "anagram";
        string t = "nagaram";

        var result = IsAnagram(s, t);
        Console.WriteLine(result);
    }

    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var leftStr = s.Select(x => x).Order();
        var rightStr = t.Select(x => x).Order();

        return string.Join("", leftStr) == string.Join("", rightStr);
    }
}
