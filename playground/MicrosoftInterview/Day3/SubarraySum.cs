namespace MicrosoftInterview;

public partial class Solution
{
    public static int SubArraySum(int[] nums, int k)
    {
        int count = 0;

        // Loop through each starting index for subarray
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;

            // Expand the subarray from index i onward
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j]; // add next element

                if (sum == k)
                {
                    count++; // found a valid subarray
                }
            }
        }

        return count;
    }
}
