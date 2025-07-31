using System.Text.RegularExpressions;

namespace NeetCode.TwoPointer;

public class P680
{
    public static void Run()
    {
        // string s = "abc";
        // string s = "abca";
        // string s = "deeee";
        string s = "eedede";

        var result = ValidPalindrome(s);
        Console.WriteLine(result);
    }

    public static bool ValidPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                // Try skipping left OR right character
                return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
            }
            l++;
            r--;
        }

        return true;
    }

    private static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }
        return true;
    }
}
