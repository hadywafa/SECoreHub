namespace NeetCode.Stack;

public class P20
{
    public static void Run()
    {
        string s = "([])";
        var result = IsValid_1(s);
        System.Console.WriteLine(result);
    }

    // ✅ 🥸 Not Readable
    public static bool IsValid_1(string s)
    {
        //"([])"
        var closedBracketDict = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            // closing bracket
            if (closedBracketDict.ContainsKey(c))
            {
                //❌ last one starting with closing bracket
                if (stack.Count == 0)
                    return false;
                // ❌ last one is closed or opened but doesn't match the closet one
                if (stack.Peek() != closedBracketDict[c])
                    return false;
                // ✅ last one match current closed bracket
                stack.Pop();
            }
            else
            {
                // opening bracket
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }

    // ✅ 🥸 Not Readable
    public bool IsValid_2(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();
                if (
                    (c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '[')
                )
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }

    //❌ Does Not Respect the Order => "([)]"
    public static bool IsValid_x(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            { '(', 0 },
            { '[', 0 },
            { '{', 0 },
        };
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                dict['(']++;
            else if (s[i] == '[')
                dict['[']++;
            else if (s[i] == '{')
                dict['{']++;
            //------------------------
            else if (s[i] == ')')
            {
                if (!dict.ContainsKey('('))
                    return false;
                dict['(']--;
            }
            else if (s[i] == ']')
            {
                if (!dict.ContainsKey('['))
                    return false;
                dict['[']--;
            }
            else if (s[i] == '}')
            {
                if (!dict.ContainsKey('{'))
                    return false;
                dict['{']--;
            }
        }

        foreach (var item in dict)
        {
            if (item.Value != 0)
                return false;
        }
        return true;
    }
}
