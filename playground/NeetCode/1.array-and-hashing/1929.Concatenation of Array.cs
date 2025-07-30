namespace NeetCode.ArraysAndHashing;

public class P1929
{
    public static void Run()
    {
        var nums = new[] { 1, 2, 1 };
        var result = GetConcatenation(nums);
        Console.WriteLine(result.HwToString());
    }

    public static int[] GetConcatenation(int[] nums)
    {
        var result = new List<int> { };
        result.AddRange(nums);

        foreach (var item in nums)
            result.Add(item);

        return result.ToArray();
    }
}
