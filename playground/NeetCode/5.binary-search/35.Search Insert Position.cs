namespace NeetCode.BinarySearch;

public class P35
{
    public static void Run()
    {
        // int[] nums = [1, 3, 5, 6];
        // int target = 5;
        //-----------------------
        // int[] nums = [1, 3, 5, 6];
        // int target = 2;
        //-----------------------
        // int[] nums = [1, 3, 5, 6];
        // int target = 7;
        //-----------------------
        // int[] nums = [1, 3, 5, 6];
        // int target = 0;
        //-----------------------
        int[] nums = [1, 3];
        int target = 4;
        //-----------------------
        var result = SearchInsert(nums, target);
        System.Console.WriteLine(result);
    }

    public static int SearchInsert(int[] nums, int target)
    {
        int mid = nums.Length / 2;

        // Going left: if target is less than mid
        if (nums[mid] > target)
        {
            while (mid >= 0)
            {
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] < target)
                    return mid + 1;
                mid--;
            }

            // If we reach the start and target is smaller than all
            return 0;
        }
        else // Going right
        {
            while (mid < nums.Length)
            {
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] > target)
                    return mid;

                mid++;
            }

            // If we reach the end and target is bigger than all
            return nums.Length;
        }
    }

    public static int SearchInsert_AI(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        // At the end of loop, left is the correct insert position
        return left;
    }
    
}
