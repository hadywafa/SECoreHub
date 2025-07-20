namespace NeetCode.Stack;

//🔞 it can be solved using Backtracking or Dynamic Programming (Not Stack)
public class P4
{
    public static void Run()
    {
        int n = 3;
        var result = GenerateParenthesis(n);
        System.Console.WriteLine(result.ToArray().HwToString());
    }

    public static IList<string> GenerateParenthesis(int n)
    {
        return new List<string>();
    }
}
