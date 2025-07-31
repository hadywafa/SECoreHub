using System.Data;

namespace NeetCode.BinarySearch;

public class P704
{
    public static void Run()
    {
        int[] nums = [-1, 0, 3, 5, 9, 12];
        int target = 9;
        var result = Search_Solution1(nums, target);
        System.Console.WriteLine(result);
    }

    // ✅ Solution 😎⚡
    public static int Search_Solution1(int[] nums, int target)
    {
        int length = nums.Length;
        int pointer = (length / 2);
        int? dir = null;
        while (pointer >= 0 && pointer < length)
        {
            int current = nums[pointer];
            if (current == target)
                return pointer;
            else if (current < target && dir != 0)
            {
                pointer++;
                dir = 1;
            }
            else if (current > target && dir != 1)
            {
                pointer--;
                dir = 0;
            }
            else
                return -1;
        }
        return -1;
    }
}
