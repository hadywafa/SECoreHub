namespace NeetCode.SlidingWindow;

public class P219
{
    public static void Run()
    {
        int[] nums = [1, 2, 3, 1];
        int k = 3;
        //-------------------------
        // int[] nums = [1,0,1,1];
        // int k = 1;
        //-------------------------
        // int[] nums = [1,2,3,1,2,3];
        // int k = 2;
        //-------------------------
        var result = ContainsNearbyDuplicate(nums, k);
        System.Console.WriteLine(result);
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (Math.Abs(i - dict[nums[i]]) <= k)
                    return true;
                dict[nums[i]] = i;
            }
            else
            {
                dict.Add(nums[i], i);
            }
        }
        return false;
    }
}
