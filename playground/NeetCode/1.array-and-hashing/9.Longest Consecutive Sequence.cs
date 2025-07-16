namespace NeetCode.ArraysAndHashing;

public class P9
{
    public static void Run()
    {
        int[] nums = [100, 4, 200, 1, 3, 2];
        // int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
        // int[] nums = [];

        var result = LongestConsecutive_S2(nums);
        System.Console.WriteLine(result);
    }

    public static int LongestConsecutive_S2(int[] nums)
    {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);

        int seqCount = 1;
        int max = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            var current = nums[i];
            var prev = nums[i - 1];
            if (current == prev)
                continue;

            if (current == (prev + 1))
                seqCount++;
            else
            {
                max = Math.Max(max, seqCount);
                seqCount = 1;
            }
        }
        max = Math.Max(max, seqCount);

        return max;
    }

    public int LongestConsecutive_S1(int[] nums)
    {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);

        int pointer = 0;
        int seqCount = 1;
        var dict = new Dictionary<int, int>();
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                continue;
            if (nums[i] == (nums[i - 1] + 1))
                seqCount++;
            else
            {
                dict.Add(pointer, seqCount);
                pointer = i;
                seqCount = 1;
            }
        }
        dict[pointer] = seqCount;
        var max = dict.Max(x => x.Value);

        return max;
    }
}