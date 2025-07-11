using System;

namespace MicrosoftInterview;

public partial class Solution
{
    public static int[][] MergeIntervals(int[][] intervals)
    {
        // [[1,3],[2,6],[8,10],[15,18]] => [[1,6],[8,10],[15,18]]

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var result = new List<int[]>();
        int[] temp = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            var current = intervals[i];
            if (current[0] <= temp[1])
            {
                // Overlap → merge by updating end
                temp[1] = Math.Max(temp[1], current[1]);
            }
            else
            {
                // No overlap → store the previous and start new
                result.Add(temp);
                temp = current;
            }
        }

        // Add the last interval
        result.Add(temp);

        return result.ToArray();
    }
}
