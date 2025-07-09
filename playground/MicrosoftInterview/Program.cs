using MicrosoftInterview;

// int[] nums1 = [1, 2, 3, 0, 0, 0];
int[] nums1 = [4, 5, 6, 0, 0, 0];
int m = 3;
int[] nums2 = [1, 2, 3];
int n = 3;

var result = Solution.Merge(nums1, m, nums2, n);

Console.WriteLine(result.HwToString());
