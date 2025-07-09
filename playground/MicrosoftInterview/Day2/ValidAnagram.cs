namespace MicrosoftInterview;

public partial class Solution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        var leftStr = s.Select(x => x).Order();
        var rightStr = t.Select(x => x).Order();

        return string.Join("", leftStr) == string.Join("", rightStr);
    }
}
