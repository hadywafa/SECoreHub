namespace MicrosoftInterview;

public partial class Solution
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // int[] nums1 = [1, 2, 3, 0, 0, 0];
        // int m = 3;
        // int[] nums2 = [2, 5, 6];
        // int n = 3;

        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

        // Buble Sort
        foreach (var item in nums1)
        {
            for (int j = 1; j < nums1.Length; j++)
            {
                int prev = nums1[j - 1];
                int curr = nums1[j];
                if (prev > curr)
                {
                    //swap
                    nums1[j - 1] = curr;
                    nums1[j] = prev;
                }
            }
        }

        return nums1;
    }
}
