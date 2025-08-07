using System.Data;

namespace NeetCode.BinarySearch;

public class P704
{
    public static void Run()
    {
        int[] nums = [-1, 0, 3, 5, 9, 12];
        // int target = 9;
        int target = 2;
        var result = BinarySearch(nums, target);
        System.Console.WriteLine(result);
    }

    public static int BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Not found
    }

    // ✅ Solution 😎⚡
    public static int Search_2(int[] nums, int target)
    {
        int length = nums.Length;
        int pointer = (length / 2);
        int? dir = null;
        while (pointer >= 0 && pointer < length)
        {
            int current = nums[pointer];
            if (current == target)
                return pointer;
            else if (current < target && dir != 0)
            {
                pointer++;
                dir = 1;
            }
            else if (current > target && dir != 1)
            {
                pointer--;
                dir = 0;
            }
            else
                return -1;
        }
        return -1;
    }

    // the Best
    public static int Search_3(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;

        if (l == r)
        {
            if (nums[l] == target)
                return l;
            return -1;
        }

        while (l < r)
        {
            if (l == r - 1)
            {
                if (nums[l] == target)
                    return l;
                else if (nums[r] == target)
                    return r;
                else
                    return -1;
            }
            int mid = l + (r - l) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
            {
                r = mid;
            }
            else if (nums[mid] < target)
            {
                l = mid;
            }
        }
        return -1;
    }
}
