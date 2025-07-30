using System.Collections;

namespace NeetCode.ArraysAndHashing;

public class P27
{
    public static void Run()
    {
        // var nums = new[] { 3, 2, 2, 3 };
        // int val = 3;
        var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;
        // var nums = new[] { 1 };
        // int val = 1;

        var result = RemoveElement(nums, val);
        Console.WriteLine(nums.HwToString());
        Console.WriteLine(result);
    }

    public static int RemoveElement(int[] nums, int val)
    {
        int pt = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                if (pt == nums.Length)
                    pt--;
                //swap
                while (pt > i)
                {
                    if (nums[pt] != val)
                    {
                        int temp = nums[i];
                        nums[i] = nums[pt];
                        nums[pt] = temp;
                        break;
                    }
                    else
                    {
                        pt--;
                    }
                }
            }
        }

        return pt;
    }
}
