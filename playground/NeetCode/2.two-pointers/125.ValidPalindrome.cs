using System.Text.RegularExpressions;

namespace NeetCode.TwoPointer;

public class P125
{
    public static void Run()
    {
        string s = "A man, a plan, a canal: Panama";

        var result = IsPalindrome_S1(s);
        Console.WriteLine(result);
    }

    private static bool IsPalindrome_S1(string s)
    {
        s = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");
        int l = 0;
        int r = s.Length - 1;
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }
        return true;
    }

    public static bool IsPalindrome_S2(string s)
    {
        //lamal
        string cleanInput = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

        var index = cleanInput.Length / 2;

        for (int i = 0; i < index; i++)
        {
            if (cleanInput[i] != cleanInput[cleanInput.Length - (i + 1)])
                return false;
        }

        return true;
    }
}
