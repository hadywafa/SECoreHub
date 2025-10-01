namespace NeetCode.ArraysAndHashing;

public class P238
{
    public static void Run()
    {
        // int[] nums = [1, 2, 3, 4];
        // int[] nums = [-1, 1, 0, -3, 3];
        int[] nums = [0, 0];

        var result = ProductExceptSelf_1(nums);

        System.Console.WriteLine(result.HwToString());
    }

    public static int[] ProductExceptSelf_1(int[] nums)
    {
        int productWithoutZeros = 1;
        var zeroIndices = new HashSet<int>();
        var result = new int[nums.Length];

        // First pass: calculate product of all non-zero elements and track zero indices
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (num == 0)
            {
                zeroIndices.Add(i);
            }
            else
            {
                productWithoutZeros *= num;
            }
        }

        // Second pass: build result array based on zero count
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num == 0)
            {
                // If there's more than one zero, all results are zero
                result[i] = (zeroIndices.Count > 1) ? 0 : productWithoutZeros;
            }
            else
            {
                // If there's at least one zero, all non-zero positions become zero
                result[i] = (zeroIndices.Count >= 1) ? 0 : productWithoutZeros / num;
            }
        }

        return result;
    }

    public static int[] ProductExceptSelf_2(int[] nums)
    {
        int[] result = new int[nums.Length];
        int allProduct = 1;
        int zeroItemsCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zeroItemsCount++;
            else
                allProduct *= nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (zeroItemsCount > 1)
            {
                result[i] = 0;
            }
            else if (zeroItemsCount == 1)
            {
                if (nums[i] == 0)
                    result[i] = allProduct;
                else
                    result[i] = 0;
            }
            else if (zeroItemsCount == 0)
            {
                result[i] = allProduct / nums[i];
            }
        }
        return result;
    }

    public static int[] ProductExceptSelf_3(int[] nums)
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
