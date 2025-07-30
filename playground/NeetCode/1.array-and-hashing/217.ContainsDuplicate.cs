using System.Collections;

namespace NeetCode.ArraysAndHashing;

public class P217
{
    public static void Run()
    {
        var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };

        var result = ContainsDuplicate_2(nums);
        Console.WriteLine(result);
    }

    public static bool ContainsDuplicate_2(int[] nums)
    {
        // x = loop1 foreach number and store temo each item value
        // y = loop2 foreach again over numbers and any item equal to temp value then return true <Note skip current item index for second loop>
        //[1,2,3,1]

        var uniqueList = new List<int> { nums[0] };

        for (int x = 1; x < nums.Length; x++)
        {
            if (uniqueList.Contains(nums[x]))
                return true;
            uniqueList.Add(nums[x]);
        }
        return false;
    }

    public static bool ContainsDuplicate_1(int[] nums)
    {
        var numbers = new HashSet<int>();

        foreach (int number in nums)
        {
            if (numbers.Contains(number))
                return true;
            numbers.Add(number);
        }

        return false;
    }
}
