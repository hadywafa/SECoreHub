using System.Security.Cryptography.X509Certificates;

namespace NeetCode.ArraysAndHashing;

public class P42
{
    public static void Run()
    {
        int[] height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
        // int[] height = [4, 2, 0, 3, 2, 5];
        // int[] height = [4, 2, 3];
        var result = Trap(height);
        Console.WriteLine(result);
    }

    public static int Trap(int[] height)
    {
        int l = 0,
            r = 1,
            result = 0;

        // =============== Left to Right =====================
        while (r < height.Length)
        {
            if (height[r] >= height[l])
            {
                int tempSum = 0;
                for (int i = l + 1; i < r; i++)
                {
                    tempSum += height[i];
                }
                int width = r - l - 1;
                int boundedHeight = height[l];
                result += Math.Max(0, boundedHeight * width - tempSum);

                l = r;
            }
            r++;
        }

        // ===============  Right to Left =====================
        r = height.Length - 1;
        l = r - 1;

        while (l >= 0)
        {
            if (height[l] > height[r])
            {
                int tempSum = 0;
                for (int i = r - 1; i > l; i--)
                {
                    tempSum += height[i];
                }
                int width = r - l - 1;
                int boundedHeight = height[r];
                result += Math.Max(0, boundedHeight * width - tempSum);

                r = l;
            }
            l--;
        }

        return result;
    }
}
