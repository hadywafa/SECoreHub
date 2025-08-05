namespace NeetCode.ArraysAndHashing;

/// <summary>
/// 
/// </summary>
public class P128
{
    public static void Run()
    {
        int[] nums = [100, 4, 200, 1, 3, 2];
        // int[] nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
        // int[] nums = [];

        var result = LongestConsecutive_1(nums);
        System.Console.WriteLine(result);
    }

    public static int LongestConsecutive_1(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        int maxLength = 0;

        foreach (int num in set) {
            // Only start at the beginning of a sequence
            if (!set.Contains(num - 1)) {
                int current = num;
                int length = 1;

                while (set.Contains(current + 1)) {
                    current++;
                    length++;
                }

                maxLength = Math.Max(maxLength, length);
            }
        }

        return maxLength;
    }
    
    public static int LongestConsecutive_2(int[] nums)
    {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);

        int count = 1;
        int maxCount = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            var current = nums[i];
            var prev = nums[i - 1];
            if (current == prev)
                continue;

            if (current == (prev + 1))
                count++;
            else
            {
                maxCount = Math.Max(maxCount, count);
                count = 1;
            }
        }
        maxCount = Math.Max(maxCount, count);

        return maxCount;
    }

    public int LongestConsecutive_3(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

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
