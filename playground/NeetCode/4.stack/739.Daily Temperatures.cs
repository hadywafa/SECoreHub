namespace NeetCode.Stack;

public class P739
{
    public static void Run()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        var result = DailyTemperatures_1(temperatures);
        System.Console.WriteLine(result.ToArray().HwToString());
    }

    public static int[] DailyTemperatures_1(int[] temperatures)
    {
        int[] answers = new int[temperatures.Length];
        var prevColdTempIndecies = new Stack<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (
                prevColdTempIndecies.Count > 0
                && temperatures[i] > temperatures[prevColdTempIndecies.Peek()]
            )
            {
                int prevColdTempIndex = prevColdTempIndecies.Pop();
                answers[prevColdTempIndex] = i - prevColdTempIndex;
            }
            prevColdTempIndecies.Push(i);
        }
        return answers;
    }

    // ❌⌛ TIME_OUT
    public static int[] DailyTemperatures_2(int[] temperatures)
    {
        var list = new List<int>();
        for (int i = 0; i < temperatures.Length; i++)
        {
            int r = i + 1;
            int count = 0;
            bool isGreater = false;
            while (r < temperatures.Length)
            {
                count++;
                if (temperatures[r] > temperatures[i])
                {
                    list.Add(count);
                    isGreater = true;
                    break;
                }
                r++;
            }
            if (!isGreater)
                list.Add(0);
        }
        return list.ToArray();
    }
}
