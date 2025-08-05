namespace NeetCode.TwoPointer;

public class P167
{
    public static void Run()
    {
        // int[] numbers = [2, 7, 11, 15];
        // int target = 9;

        // int[] numbers = [2, 3, 4];
        // int target = 6;

        // int[] numbers = [0, 0, 3, 4];
        // int target = 0;


        int[] numbers = [5, 25, 75];
        int target = 100;

        var result = TwoSum_1(numbers, target);
        Console.WriteLine(result.HwToString());
    }

    public static int[] TwoSum_1(int[] numbers, int target) {
        
        int l = 0;
        int r = numbers.Length - 1;
        while(l < r)
        {
            int sum = numbers[r] + numbers[l];

            if(sum == target)
                return [l + 1, r + 1];

            if(sum > target)
            {
                r--;
                // l = 0;
            }
            else
                l++;
        }
        return [l + 1, r + 1];
    }

    public static int[] TwoSum_2(int[] numbers, int target)
    {
        int p1 = 0;
        int p2 = numbers.Length - 1;
        while (p2 > 0 && p1 < numbers.Length)
        {
            var num1 = numbers[p1];
            var num2 = numbers[p2];

            if (num1 + num2 == target)
                break;

            if (num1 + num2 > target)
                p2--;

            if (num1 + num2 < target)
            {
                p1++;
            }
        }
        return [p1 + 1, p2 + 1];
    }
}
