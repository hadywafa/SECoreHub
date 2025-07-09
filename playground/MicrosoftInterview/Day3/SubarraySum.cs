namespace MicrosoftInterview;

public partial class Solution
{
    public static int SubArraySum(int[] nums, int k)
    {
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var tempList = new List<int>() { nums[i] };

            if (nums[i] == k)
            {
                count++;
                // break;
            }

            for (int j = i; j < nums.Length; j++)
            {
                if ((j + 1) == nums.Length)
                    break;

                var nextItem = nums[j + 1];

                tempList.Add(nextItem);
                var sum = tempList.Sum();
                if (sum < k)
                {
                    continue;
                }
                else if (sum == k)
                {
                    count++;
                    continue;
                }
                else
                    break;
            }
        }
        return count;
    }
}
