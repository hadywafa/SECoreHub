using System.ComponentModel;

namespace MicrosoftInterview;

public partial class Solution
{
    public static bool IsValidParentheses(string s)
    {
        //"([])"
        var dict = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (dict.ContainsKey(c)) // closing bracket
            {
                if (stack.Count == 0 || stack.Peek() != dict[c])
                    return false;

                stack.Pop(); // matched open-close pair
            }
            else
            {
                stack.Push(c); // opening bracket
            }
        }

        return stack.Count == 0;
    }
}
