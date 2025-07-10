namespace MicrosoftInterview;

public partial class Solution
{
    public static int FindContentChildren(int[] g, int[] s)
    {
        // int[] g = [1,2,3];
        // int[] s = [1,1];
        //-------------------------
        Array.Sort(g);
        Array.Sort(s);
        //-------------------------
        int happyChildrenCount = 0;
        int pointerForCurrentChild = 0;
        int pointerForUsedCookie = 0;
        //-------------------------
        while (pointerForCurrentChild < g.Length && pointerForUsedCookie < s.Length)
        {
            // var currentChildGreed = g[pointerForCurrentChild];
            // var currentCookieSize = s[pointerForUsedCookie];

            if (s[pointerForUsedCookie] >= g[pointerForCurrentChild])
            {
                happyChildrenCount++;
                pointerForCurrentChild++;
                pointerForUsedCookie++;
            }
            else
            {
                pointerForUsedCookie++;
            }
        }
        return happyChildrenCount;
    }
}
