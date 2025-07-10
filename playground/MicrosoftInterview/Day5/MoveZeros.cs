namespace MicrosoftInterview;

public partial class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        //[0,1,0,3,12]
        //[0,0,1]
        int targetSwap = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                continue;

            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] == 0)
                    continue;

                //swap
                var origin = nums[i];
                var current = nums[j];
                var prev = nums[j - 1];

                if (origin == 0)
                {
                    nums[i] = current;
                    nums[j - 1] = origin;
                }
                else
                {
                    nums[j] = prev;
                    nums[j - 1] = current;
                }
            }
        }

        System.Console.WriteLine(nums.HwToString());
    }
}
