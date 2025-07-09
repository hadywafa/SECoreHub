namespace MicrosoftInterview;

public partial class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var firstItem = strs[0];
        var lastIndex = firstItem.Length;
        var result = "";
        mark:
        result = firstItem.Substring(0, lastIndex);
        for (int i = 1; i < strs.Length; i++)
        {
            if (!strs[i].StartsWith(result))
            {
                lastIndex--;
                if (lastIndex >= 0)
                    goto mark;
            }
        }

        return result;
    }
}
