namespace MicrosoftInterview;

public partial class Solution
{
    public static int SubArraySum(int[] nums, int k)
    {
        // declare slid window with inital two first item
        // if sum of slidWindow = k => return
        // else if > k => add next item to slidwindow and retry;
        // else if < k => remove first add next and retry

        var tempList = new LinkedList<int>();
        tempList.AddLast(nums[0]);
        tempList.AddLast(nums[1]);

        int i = 0;
        mark:
        i++;
        var sum = tempList.Sum();
        if (tempList.Sum() == k)
            return tempList.Count;
        else if (sum > k)
        {
            tempList.AddLast(nums[1 + i]);
            goto mark;
        }
        else if (sum < k)
        {
            tempList.RemoveFirst();
            tempList.AddLast(nums[1 + i]);
            goto mark;
        }
        else
            return 0;
    }
}
