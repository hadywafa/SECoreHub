using System.Globalization;

namespace NeetCode.BinarySearch;

public class P374
{
    public static void Run()
    {
        int n = 10;
        // int pick = 6;
        var result = GuessNumber(n);
        System.Console.WriteLine(result);
    }

    public static int GuessNumber(int n)
    {
        int mid = n / 2;
        int result = guess(mid);

        if (result == 0)
            return mid;
        else if (result == -1)
        {
            // Go left if mid is too high
            mid--;
            while (mid >= 1)
            {
                result = guess(mid);
                if (result == 0)
                    return mid;
                mid--;
            }
        }
        else if (result == 1)
        {
            // Go right if mid is too low
            mid++;
            while (mid <= n)
            {
                result = guess(mid);
                if (result == 0)
                    return mid;
                mid++;
            }
        }

        // fallback
        return -1;
    }

    public static int guess(int number)
    {
        throw new NotImplementedException(
            "The Implementation for this Method is in the Leet Code Not Here"
        );
    }
}
