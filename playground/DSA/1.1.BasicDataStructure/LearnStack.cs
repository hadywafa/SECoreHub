using System.Text;

namespace DSA.BasicDataStructure;

public class LearnStack
{
    public static void Run()
    {
        // ====================== custom implementation =========================
        CustomStack<int> myStack = new CustomStack<int>(5);

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        Console.WriteLine("Top of the stack: " + myStack.Peek());
        Console.WriteLine("Stack count: " + myStack.Count);

        while (!myStack.IsEmpty())
        {
            Console.WriteLine("Popped: " + myStack.Pop());
        }
        // ========================== built-in ==================================
        var result1 = CustomStack<string>.Reverse("hady");
        System.Console.WriteLine(result1);
        var result2 = CustomStack<string>.IsBalancedV1("( 1 + 1 ))");
        System.Console.WriteLine(result2);
        var result3 = CustomStack<string>.IsBalancedV2("(({ 1 + 1}))");
        System.Console.WriteLine(result3);
    }
}

//-----------------------------------------------

public class CustomStack<T>
{
    private T[] array;
    private int top;
    private int capacity;

    public CustomStack(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0");

        this.capacity = capacity;
        array = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full. Cannot push.");
            return;
        }

        top = (top + 1) % capacity;
        array[top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot pop.");
            return default;
        }

        T item = array[top];

        if (top == 0)
        {
            // Reset top when the last element is popped
            top = capacity - 1;
        }
        else
        {
            top = (top - 1) % capacity;
        }

        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty. Cannot peek.");
            return default;
        }

        return array[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return (top + 1) % capacity == 0;
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
            if (item == '(')
                stack.Push(item);
            if (item == ')')
            {
                if (stack.Count == 0)
                    return false;
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
        return opening == '(' && closing == ')'
            || opening == '[' && closing == ']'
            || opening == '{' && closing == '}'
            || opening == '<' && closing == '>';
    }
}
