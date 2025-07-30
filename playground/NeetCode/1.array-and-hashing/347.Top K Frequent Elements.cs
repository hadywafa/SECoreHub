namespace NeetCode.ArraysAndHashing;

public class P347
{
    public static void Run()
    {
        int[] nums = [1, 1, 1, 2, 2, 3];
        int k = 2;
        var result = TopKFrequent(nums, k);

        System.Console.WriteLine(result.HwToString());
    }

    public static int[] TopKFrequent(int[] nums, int k)
    {
        var calc = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (calc.ContainsKey(nums[i]))
            {
                calc[nums[i]]++;
            }
            else
            {
                calc.Add(nums[i], 1);
            }
        }
        return calc.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }
}