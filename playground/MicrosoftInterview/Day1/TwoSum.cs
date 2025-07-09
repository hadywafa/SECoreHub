namespace MicrosoftInterview;

public partial class Solution
{
    // foreach item in array
    // foreach item in array
    // if item[i] + item+1 = target 


    public static int[] TwoSum(int[] nums, int target)
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

    public static int[] TwoSum(bool theBest, int[] nums, int target)
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

// 
public static class StringExtensions
{

    public static string HwToString(this int[] array) => "[" + string.Join(",", array) + "]";
}