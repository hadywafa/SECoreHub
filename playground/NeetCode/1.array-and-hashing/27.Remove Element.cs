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

        var result = RemoveElement_1(nums, val);
        Console.WriteLine(nums.HwToString());
        Console.WriteLine(result);
    }

    public static int RemoveElement_1(int[] nums, int val)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int res = 0,
            maxCount = 0;

        foreach (int num in nums)
        {
            if (!count.ContainsKey(num))
            {
                count[num] = 0;
            }
            count[num]++;

            if (count[num] > maxCount)
            {
                res = num;
                maxCount = count[num];
            }
        }

        return res;
    }

    public static int RemoveElement_2(int[] nums, int val)
    {
        int r = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                //handle one item in a list
                if (r == nums.Length)
                    r--;

                while (r > i)
                {
                    if (nums[r] != val)
                    {
                        //swap
                        nums[i] = nums[r];
                        nums[r] = val;
                        break;
                    }
                    else
                        r--;
                }
            }
        }

        return r;
    }
}
