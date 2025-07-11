namespace MicrosoftInterview;

public partial class Solution
{
    public static int[][] MergeIntervals(int[][] intervals)
    {
        // [[1,3],[2,6],[8,10],[15,18]] => [[1,6],[8,10],[15,18]]

        int left = 0;
        int right = 1;
        var result = new List<int[]>();

        while (right <= intervals.Length)
        {
            
        }
        // return result.ToArray();
        return intervals;
    }
}
