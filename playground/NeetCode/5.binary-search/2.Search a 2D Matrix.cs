namespace NeetCode.BinarySearch;

public class P2
{
    public static void Run()
    {
        int[][] matrix =
        [
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        ];
        int target = 3;
        var result = SearchMatrix(nums, target);
        System.Console.WriteLine(result);
    }

    public bool SearchMatrix(int[][] matrix, int target) { }
}
