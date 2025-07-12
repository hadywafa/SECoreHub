namespace NeetCode.BinarySearch;

public class P1
{
    public static void Run()
    {
        int[] nums = [-1, 0, 3, 5, 9, 12];
        int target = 9;
        var result = Search(nums, target);
        System.Console.WriteLine(result);
    }

    public static int Search(int[] nums, int target)
    {
        int length = nums.Length;
        int pointer = (length / 2);
        int? dir = null;
        while (pointer >= 0 && pointer < length)
        {
            if (nums[pointer] == target)
                return pointer;
            else if (nums[pointer] < target && dir != 0)
            {
                pointer++;
                dir = 1;
            }
            else if (nums[pointer] > target && dir != 1)
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
