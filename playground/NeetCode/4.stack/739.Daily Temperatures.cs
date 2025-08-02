namespace NeetCode.Stack;

public class P739
{
    public static void Run()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        var result = DailyTemperatures(temperatures);
        System.Console.WriteLine(result.ToArray().HwToString());
    }

    // ❌⌛ TIME_OUT
    public static int[] DailyTemperatures(int[] temperatures)
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
