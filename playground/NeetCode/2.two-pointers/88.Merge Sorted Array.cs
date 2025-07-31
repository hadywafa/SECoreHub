namespace NeetCode.TwoPointer;

public class P88
{
    public static void Run()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int m = 3;
        int[] nums2 = [2, 5, 6];
        int n = 3;
        //------
        // int[] nums1 = [1];
        // int m = 1;
        // int[] nums2 = [];
        // int n = 0;
        //------
        // int[] nums1 = [0];
        // int m = 0;
        // int[] nums2 = [1];
        // int n = 1;
        //------
        // int[] nums1 = [4,5,6,0,0,0];
        // int m = 3;
        // int[] nums2 = [1,2,3];
        // int n = 3;
        //------
        Merge_1(nums1, m, nums2, n);
        Console.WriteLine(nums1.HwToString());
    }

 

    public static void Merge_1(int[] nums1, int m, int[] nums2, int n)
    {
        int r = 0;
        for (int l = m; l < nums1.Length; l++)
        {
            if (r < n)
            {   
                nums1[l] = nums2[r];
                r++;
            }
        }
        Array.Sort(nums1);
    }

    public static int[] Merge_2(int[] nums1, int m, int[] nums2, int n)
    {
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
