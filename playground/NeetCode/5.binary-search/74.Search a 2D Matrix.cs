namespace NeetCode.BinarySearch;

public class P74
{
    public static void Run()
    {
        int[][] matrix =
        [
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        ];
        int target = 13;
        var result = SearchMatrix(matrix, target);
        System.Console.WriteLine(result);
    }

    public static bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            var lastItem = matrix[i][matrix[i].Length - 1];
            if (lastItem < target)
                continue;

            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == target)
                    return true;
            }
        }
        return false;
    }
}
