namespace NeetCode.Stack;

public class P739
{
    public static void Run()
    {
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        var result = DailyTemperatures_AI(temperatures);
        System.Console.WriteLine(result.ToArray().HwToString());
    }

    /// <summary>
    /// Given an array of daily temperatures, returns an array where each element tells
    /// how many days you have to wait to get a warmer temperature. If no warmer day exists, value is 0.
    /// </summary>
    /// <param name="temperatures">Array of daily temperatures</param>
    /// <returns>Array of days to wait for a warmer temperature</returns>
    public static int[] DailyTemperatures_AI(int[] temperatures)
    {
        int[] answers = new int[temperatures.Length];

        // Monotonic decreasing stack: holds indices of temperatures
        // such that temperatures[stack] is in decreasing order
        var prevColdTempIndecies = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            // While current temperature is warmer than the temperature at top index of the stack
            while (
                prevColdTempIndecies.Count > 0
                && temperatures[i] > temperatures[prevColdTempIndecies.Peek()]
            )
            {
                // Found the next warmer day for the previous colder day
                int prevColdTempIndex = prevColdTempIndecies.Pop();
                answers[prevColdTempIndex] = i - prevColdTempIndex; // Days waited
            }

            // Push current index onto the stack to wait for a warmer day in the future
            prevColdTempIndecies.Push(i);
        }

        // Remaining indices in the stack never see a warmer day, so their values remain 0 by default
        return answers;
    }

    /*

    ```md

    ### 💡 Stack Pattern Summary (Daily Temperatures)

    * **What we store:** Indices of colder days
    * **When we pop:** When we find a warmer day
    * **What we calculate:** `i - prevIndex` → number of days waited
    * **What the stack ensures:** Order of decreasing temperatures

    ---

    ### 📦 Time & Space Complexity

    * **Time:** `O(n)` — Each index is pushed/popped at most once
    * **Space:** `O(n)` — Worst case, the stack holds all indices (e.g., strictly decreasing temperatures)

    ---

    ### 🧠 Real-World Analogy

    Each temperature is like a **person standing in line**, waiting for someone **hotter** to appear.
    As soon as someone hotter comes along, they look back and say,

    > "Hey you! I’m the one you’ve been waiting for!"
    > And we record how long they had to wait.

    ```
    */

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
