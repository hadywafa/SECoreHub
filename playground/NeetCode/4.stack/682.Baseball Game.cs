namespace NeetCode.Stack;

public class P682
{
    public static void Run()
    {
        // string[] ops = ["5", "2", "C", "D", "+"];
        string[] ops = ["5","-2","4","C","D","9","+","+"];
        var result = CalPoints(ops);
        System.Console.WriteLine(result);
    }

    public static int CalPoints(string[] operations) {

        var score = new Stack<int>();
        for (int i = 0; i < operations.Length; i++)
        {
            string current = operations[i];

            if (current == "D")
            {
                score.Push(2 * score.Peek());
            }
            else if (current == "+")
            {
                int no1 = score.Pop();
                int no2 = score.Peek();
                score.Push(no1);
                score.Push(no1 + no2);
            }
            else if (current == "C")
            {
                score.Pop();
            }
            else
            {
                score.Push(int.Parse(current));
            }

        }
        return score.Sum();
    }
}
