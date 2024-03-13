using System.Text;

namespace DSAL;
public static class HwStack
{
    public static string Reverse(string input)
    {
        var stack = new Stack<char>();

        foreach (char item in input)
            stack.Push(item);

        // var reversedArray = new StringBuilder();
        // foreach (var item in stack)
        //     reversedArray.Append(item);

        char[] reversedArray = new char[input.Length];
        int index = 0;
        while (stack.Count > 0)
            reversedArray[index++] = stack.Pop();

        return new string(reversedArray);
    }

    public static bool IsBalancedV1(string input)
    {
        var stack = new Stack<char>();
        foreach (var item in input)
        {
            if (item == '(') stack.Push(item);
            if (item == ')')
            {
                if (stack.Count == 0) return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
    public static bool IsBalancedV2(string input)
    {
        var stack = new Stack<char>();

        foreach (var character in input)
        {
            switch (character)
            {
                case '(':
                case '[':
                case '{':
                case '<':
                    stack.Push(character);
                    break;

                case ')':
                case ']':
                case '}':
                case '>':
                    if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), character))
                        return false;
                    break;

                // Ignore characters that are not parentheses
                default:
                    break;
            }
        }

        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']') ||
               (opening == '{' && closing == '}') ||
               (opening == '<' && closing == '>');
    }
}