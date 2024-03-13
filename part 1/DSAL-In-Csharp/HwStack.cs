using System.Text;

namespace DSAL;
public class HwStack<T>
{
    private T[] array;
    private int top;

    public HwStack(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0");

        array = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == array.Length - 1)
        {
            // Stack is full, resize the array or throw an exception
            Console.WriteLine("Stack overflow!");
            return;
        }

        array[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            // Stack is empty, throw an exception or return a default value
            Console.WriteLine("Stack underflow!");
            return default(T);
        }

        return array[top--];
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            // Stack is empty, throw an exception or return a default value
            Console.WriteLine("Stack is empty!");
            return default(T);
        }

        return array[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public int Count
    {
        get { return top + 1; }
    }
    //---------------------------------------------------------
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