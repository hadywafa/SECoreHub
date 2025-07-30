using System.Text.RegularExpressions;

namespace NeetCode.TwoPointer;

public class P125
{
    public static void Run()
    {
        string s = "A man, a plan, a canal: Panama";

        var result = IsPalindrome(s);
        Console.WriteLine(result);
    }

    public static bool IsPalindrome(string s)
    {
        //lamal
        string cleanInput = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");

        var index = cleanInput.Length / 2;

        for (int i = 0; i < index; i++)
        {
            if (cleanInput[i] != cleanInput[cleanInput.Length - (i + 1)])
                return false;
        }

        return true;
    }
}
