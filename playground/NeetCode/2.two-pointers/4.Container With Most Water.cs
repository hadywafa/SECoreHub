namespace NeetCode.TwoPointer;

public class P4
{
    public static void Run()
    {
        int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        // int[] height = [2, 3, 4, 5, 18, 17, 6];

        var result = MaxArea(height);
        Console.WriteLine(result);
    }

    public static int MaxArea(int[] height)
    {
        Array.Sort(height);
        // Area =  (right - left) * Math.Max(nums[left], nums[right])
        int maxArea = 0;
        int right = height.Length - 1;
        for (int i = height.Length - 2; i >= 0; i--)
        {
            int currentMaxArea = Math.Abs(right - i) * Math.Min(height[right], height[i]);
            maxArea = Math.Max(maxArea, currentMaxArea);
            right--;
        }

        return maxArea;
    }

    public static int MaxArea_Old_3(int[] height)
    {
        // Area =  (right - left) * Math.Max(nums[left], nums[right])
        int maxArea = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int right = height.Length - 1;
            int left = 0;

            for (int j = 0; j < height.Length - 1; j++)
            {
                int areaRight = 0;
                int areaLeft = 0;
                if (left < i)
                {
                    areaLeft = Math.Abs(i - left) * Math.Min(height[left], height[i]);
                    left++;
                }
                if (right < height.Length)
                {
                    areaRight = Math.Abs(right - i) * Math.Min(height[i], height[right]);
                    right--;
                }
                var currentMaxArea = Math.Max(areaLeft, areaRight);
                maxArea = Math.Max(maxArea, currentMaxArea);
            }
        }

        return maxArea;
    }

    // 🐌⌛
    public static int MaxArea_Old_2(int[] height)
    {
        // Area =  (right - left) * Math.Max(nums[left], nums[right])
        int maxArea = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int right = height.Length - 1;
            int left = 0;

            while (left < i && i < right)
            {
                int areaRight = Math.Abs(right - i) * Math.Min(height[i], height[right]);
                int areaLeft = Math.Abs(i - left) * Math.Min(height[left], height[i]);
                var currentMaxArea = Math.Max(areaLeft, areaRight);
                maxArea = Math.Max(maxArea, currentMaxArea);

                right--;
                left++;
            }
        }

        return maxArea;
    }

    // 🐌🐌⌛
    public static int MaxArea_Old_1(int[] height)
    {
        // Area =  (right - left) * Math.Max(nums[left], nums[right])
        int maxArea = 0;
        for (int i = 0; i < height.Length; i++)
        {
            int right = i + 1;

            while (right < height.Length)
            {
                var area = Math.Abs(right - i) * Math.Min(height[i], height[right]);
                maxArea = Math.Max(maxArea, area);
                right++;
            }

            int left = i - 1;

            while (left >= 0)
            {
                var area = Math.Abs(i - left) * Math.Min(height[left], height[i]);
                maxArea = Math.Max(maxArea, area);
                left--;
            }
        }

        return maxArea;
    }
}
