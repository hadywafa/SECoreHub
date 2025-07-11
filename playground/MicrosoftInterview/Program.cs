using MicrosoftInterview;

int[][] nums =
[
    [1, 3],
    [2, 6],
    [8, 10],
    [15, 18]
];

// int[][] nums = [[1, 4], [4, 5]];
// int[][] nums =
// [
//     [1, 4],
//     [1, 4]
// ];

// int[][] nums =
// [
//     [1, 4],
//     [0, 4]
// ];

var result = Solution.MergeIntervals(nums);

System.Console.WriteLine(result.HwToString());
