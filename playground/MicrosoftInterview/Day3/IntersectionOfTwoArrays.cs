namespace MicrosoftInterview;

public partial class Solution
{
    public static int[] IntersectionOfTwoArrays(int[] nums1, int[] nums2)
    {
        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums2.Contains(nums1[i]))
                hashSet.Add(nums1[i]);
        }
        return hashSet.ToArray();
    }
}
