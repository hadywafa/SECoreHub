using System.Data;

namespace NeetCode.BinarySearch;

public class P153
{
    public static void Run()
    {
        int[] nums = [3, 4, 5, 1, 2];
        var result = FindMin(nums);
        System.Console.WriteLine(result);
    }

    public static int FindMin(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
                return nums[i];
        }
        return nums[0];
        // return nums.Min();
    }
}
