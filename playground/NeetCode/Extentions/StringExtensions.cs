namespace NeetCode;

public static class StringExtensions
{
    public static string HwToString<T>(this T[] array) => "[" + string.Join(",", array) + "]";

    public static string HwToString<T>(this T[][] array) =>
        "[" + string.Join(",", array.Select(x => x.HwToString())) + "]";
}

