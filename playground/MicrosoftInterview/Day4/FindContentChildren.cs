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
        int pointerForUsedCookie = 0;
        //-------------------------
        for (int i = 0; i < g.Length; i++)
        {
            if (pointerForUsedCookie == s.Length)
                break;

            var currentChildGreed = g[i];
            var currentCookieSize = s[pointerForUsedCookie];

            if (currentChildGreed > currentCookieSize)
                break;

            if (currentChildGreed <= currentCookieSize)
            {
                happyChildrenCount++;
                pointerForUsedCookie++;
            }
        }

        return happyChildrenCount;
    }
}
