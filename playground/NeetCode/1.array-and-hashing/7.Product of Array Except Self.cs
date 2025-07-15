namespace NeetCode.ArraysAndHashing;

public class P7
{
    public static void Run()
    {
        // int[] nums = [1, 2, 3, 4];
        int[] nums = [-1, 1, 0, -3, 3];

        var result = ProductExceptSelf(nums);

        System.Console.WriteLine(result.HwToString());
    }

    public static int[] ProductExceptSelf(int[] nums)
    {
        var AllMultiplication = 1;
        var zeroIndex = new HashSet<int>();
        var results = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var item = nums[i];
            AllMultiplication *= (item != 0) ? item : 1;
            if (item == 0)
                zeroIndex.Add(i);

        }

        for (int i = 0; i < nums.Length; i++)
        {
            var item = nums[i];
            if (item == 0)
            {
                zeroIndex.Remove(i);
                if (zeroIndex.Count >= 1)
                {
                    results[i] = 0;
                }
                else
                {
                    results[i] = AllMultiplication;
                }
                zeroIndex.Add(i);
            }
            else
            {
                if (zeroIndex.Count >= 1)
                {
                    results[i] = 0;
                }
                else
                {
                    results[i] = AllMultiplication / item;

                }
            }
        }

        return results;
    }

    public static int[] ProductExceptSelf_Old(int[] nums)
    {
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var multiplication = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                    multiplication *= nums[j];
            }
            result.Add(multiplication);
        }
        return result.ToArray();
    }
}