namespace MicrosoftInterview;

public partial class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        //[0,1,0,3,12]
        //[0,0,1]
        //-------------------------------------
        var left = 0;
        var right = 1;

        while (right < nums.Length)
        {
            if (nums[left] == 0 && nums[right] != 0)
            {
                (nums[right], nums[left]) = (nums[left], nums[right]);
            }

            right++;

            if (nums[left] != 0 && left < right - 1)
                left++;
        }

        System.Console.WriteLine(nums.HwToString());
    }
}


// {
//     //[0,1,0,3,12]
//     //[0,0,1]
//     //-------------------------------------
//     int lastZeroIndex = -1;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if (nums[i] == 0 && (i + 1) < nums.Length)
//         {
//             var next = nums[i + 1];
//             if (next == 0)
//             {
//                 lastZeroIndex = i;
//                 continue;
//             }
//             else
//             {
//                 lastZeroIndex = i + 1;
//             }

//             nums[i + 1] = 0;
//             nums[lastZeroIndex] = next;
//         }
//     }

//     System.Console.WriteLine(nums.HwToString());
// }
