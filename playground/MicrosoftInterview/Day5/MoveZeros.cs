namespace MicrosoftInterview;

public partial class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        //[0,1,0,3,12]
        //[0,0,1]
        //-------------------------------------
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                continue;

            for (int j = i; j > 0; j--)
            {
                var current = nums[j];
                var prev = nums[j - 1];

                if (prev != 0)
                    break;

                nums[j] = prev;
                nums[j - 1] = current;
            }
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
