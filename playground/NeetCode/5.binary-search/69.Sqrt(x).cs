namespace NeetCode.BinarySearch;

public class P69
{
    public static void Run()
    {
        int x = 4;
        var result = MySqrt_AI(x);
        System.Console.WriteLine(result);
    }

    public static int MySqrt_AI(int x)
    {
        if (x < 2)
            return x; // √0 = 0, √1 = 1

        int left = 1;
        int right = x / 2;
        int result = 0;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Use long to avoid int overflow when squaring
            long square = (long)mid * mid;

            if (square == x)
                return mid;
            else if (square < x)
            {
                result = mid; // store possible answer
                left = mid + 1; // try a bigger number
            }
            else
            {
                right = mid - 1; // try a smaller number
            }
        }

        return result;
    }
}
