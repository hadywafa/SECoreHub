namespace NeetCode.TwoPointer;

public class P26
{
    public static void Run()
    {
        // int[] nums = [1, 1];
        // int[] nums = [1, 2];
        // int[] nums = [1, 1, 2];
        int[] nums = [0,0,1,1,1,2,2,3,3,4];

        var result = RemoveDuplicates_1(nums);
        Console.WriteLine(result + " => " +nums.HwToString());
    }

    public static int RemoveDuplicates_1(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int insertPos = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[insertPos - 1])
            {
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        return insertPos;
    }

    public static int RemoveDuplicates_2(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;
        HashSet<int> set = new HashSet<int>();
        while (l <= r)
        {
            if (set.Add(nums[l]))
            {
                l++;
            }
            else
            {
                int i = l;
                while (i < r)
                {
                    int tmp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = tmp;
                    i++;
                }
                r--;
            }
        }
        return l;
    }
}
