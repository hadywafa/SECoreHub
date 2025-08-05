namespace NeetCode.TwoPointer;

public class P15
{
    public static void Run()
    {
        int[] numbers = [-1, 0, 1, 2, -1, -4];
        // int[] numbers = [0, 0, 0, 0];
        // int[] numbers = [1, 2, -2, -1];
        // int[] numbers = [1, -1, -1, 0];
        // int[] numbers = [-2, 0, 1, 1, 2];
        // int[] numbers = [2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10];

        var result = ThreeSum(numbers);
        Console.WriteLine(result.Select(x => x.ToArray()).ToArray().HwToString());
    }

    // 🔞😭
    public static IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var set = new HashSet<string>();
        var result = new List<IList<int>>();
        for(int i = 0; i < nums.Length; i++)
        {
            // skip duplicates
            if (i > 0 && nums[i] == nums[i - 1])
                continue; 

            //two sum
            int l = i + 1;
            int r = nums.Length - 1;
            while(l < r)
            {
                int sum = nums[i]  + nums[l] + nums[r];
                if(sum == 0)
                {
                    // if pattern repeated, skip it please 
                    string tripletKey = $"{nums[i]},{nums[l]},{nums[r]}";
                    if (!set.Contains(tripletKey))
                    {
                        var list = new List<int>
                        {
                            nums[i], nums[r] , nums[l]
                        };
                        result.Add(list);
                        set.Add(tripletKey);
                    }

                    l++;
                    r--;
                }
                
                else if(sum > 0)
                    r--;
                else if(sum < 0)
                    l++;
            }
        }
        return result;
    }

    // ❌ 😎 very proud of myself
    public static IList<IList<int>> ThreeSum_OLD(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<IList<int>>();
        int pFirst = 0;
        int pMiddle = 1;
        int pLast = nums.Length - 1;
        // int pMiddle = pLast / 2;
        var reservedNumbers = new List<int>();
        while (pFirst < nums.Length && pLast > 0 && pMiddle < pLast && pMiddle > pFirst)
        {
            int num1 = nums[pFirst];
            int num2 = nums[pMiddle];
            int num3 = nums[pLast];

            if (num1 + num2 + num3 == 0)
            {
                if (!reservedNumbers.Contains(num2))
                {
                    result.Add([num1, num2, num3]);
                    reservedNumbers.Add(num2);
                }
                else
                {
                    pMiddle++;
                }

            }
            else if (num1 + num2 + num3 < 0)
            {
                // Case 1 => increase [pMiddle]
                if ((pFirst + 1) > pMiddle)
                {
                    pMiddle++;
                }
                // Case 2 => increase [pFirst] 
                else if ((pFirst + 1) < pMiddle)
                {
                    pFirst++;
                }
                // Case 3 => increase Both [pFirst, pMiddle]
                else
                {
                    pFirst++;
                    pMiddle++;
                }
            }
            else if (num1 + num2 + num3 > 0)
            {
                // Case 1 => reduce [pMiddle]
                if ((pLast - 1) < pMiddle)
                {
                    pMiddle--;
                }
                // Case 2 => reduce [pLast] 
                else if ((pLast - 1) > pMiddle)
                {
                    pLast--;
                }
                // Case 3 => reduce both [pLast, pMiddle]
                else
                {
                    pLast--;
                    pMiddle--;
                }
            }
        }
        return result;
    }
}
