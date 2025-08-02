using System.Data;

namespace NeetCode.BinarySearch;

public class P875
{
    public static void Run()
    {
        int[] piles = [3, 6, 7, 11];
        int h = 8;
        var result = MinEatingSpeed(piles, h);
        System.Console.WriteLine(result);
    }

    public static int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            long hoursNeeded = 0;

            foreach (int pile in piles)
            {
                // hoursNeeded += (long)Math.Ceiling((decimal)pile / (decimal)mid);
                hoursNeeded += (pile + mid - 1) / mid; // Faster than using Math.Ceiling
            }

            if (hoursNeeded <= h)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }
}
