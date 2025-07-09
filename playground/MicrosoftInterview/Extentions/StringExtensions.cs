namespace MicrosoftInterview;

public static class StringExtensions
{
    public static string HwToString(this int[] array) => "[" + string.Join(",", array) + "]";
}
