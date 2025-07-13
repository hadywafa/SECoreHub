namespace NeetCode;

public static class StringExtensions
{
    public static string HwToString(this int[] array) => "[" + string.Join(",", array) + "]";

    public static string HwToString(this int[][] array) =>
        "[" + string.Join(",", array.Select(x => x.HwToString())) + "]";
}
