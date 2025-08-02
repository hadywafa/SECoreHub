namespace NeetCode.ArraysAndHashing;

public class P1
{
    public static void Run()
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;

        var result = TwoSum_1(nums, target);
        Console.WriteLine(nums.HwToString());
    }

    public static int[] TwoSum_2(int[] nums, int target)
    {
        // foreach item in array
        // foreach item in array
        // if item[i] + item+1 = target

        for (int i = 0; i < nums.Length; i++)
        {
            for (int y = 0; y < nums.Length; y++)
            {
                if (i == y)
                    continue;
                if (nums[i] + nums[y] == target)
                    return [i, y];
            }
        }

        return [];
    }

    public static int[] TwoSum_1(int[] nums, int target)
    {
        Dictionary<int, int> pair = new Dictionary<int, int>();
        pair[nums[0]] = 0;
        for (int x = 1; x < nums.Length; x++)
        {
            if (pair.ContainsKey(target - nums[x]))
            {
                return new int[] { pair[target - nums[x]], x };
            }
            pair[nums[x]] = x;
            continue;
        }
        return new int[] { };
    }
}
