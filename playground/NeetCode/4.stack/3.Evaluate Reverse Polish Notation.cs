namespace NeetCode.Stack;

public class P3
{
    static Dictionary<string, Func<int, int, int>> operators = new Dictionary<
        string,
        Func<int, int, int>
    >
    {
        { "+", (x, y) => x + y },
        { "-", (x, y) => x - y },
        { "*", (x, y) => x * y },
        { "/", (x, y) => y != 0 ? x / y : throw new DivideByZeroException() },
    };

    public static void Run()
    {
        // string[] tokens = ["2", "1", "+", "3", "*"];
        // string[] tokens = ["4", "13", "5", "/", "+"];
        string[] tokens = ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"];
        var result = EvalRPN(tokens);
        System.Console.WriteLine(result);
    }

    public static int EvalRPN(string[] tokens)
    {
        var stack = new Stack<string>();

        for (int i = 0; i < tokens.Length; i++)
        {
            // if item is operator
            if (IsOperator(tokens[i]) && stack.Count > 1)
            {
                var item1 = stack.Pop();
                var item2 = stack.Pop();
                var result = Calculate(int.Parse(item2), int.Parse(item1), tokens[i]);
                stack.Push(result.ToString());
            }
            else
                stack.Push(tokens[i]);
        }
        return int.Parse(stack.Pop());
    }

    private static bool IsOperator(string item)
    {
        return operators.Keys.Contains(item);
    }

    private static int Calculate(int num1, int num2, string symbol)
    {
        if (operators.TryGetValue(symbol, out var expression))
            return expression(num1, num2);
        else
            throw new ArgumentException($"this {symbol} are Invalid Operator");
    }
}
