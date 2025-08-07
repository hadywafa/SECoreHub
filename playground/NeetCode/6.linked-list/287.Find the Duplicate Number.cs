namespace NeetCode.LinkedList;

public static class P287
{
    public static void Run()
    {
        //------------------------------------------
        int[] nums = [1, 3, 4, 2, 2];
        var result = FindDuplicate_AI(nums);
        Console.WriteLine(result);
    }

    public static int FindDuplicate_AI(int[] nums)
    {
        // Step 1: Find the meeting point inside the cycle
        int slow = nums[0];
        int fast = nums[0];

        do
        {
            slow = nums[slow]; // move 1 step
            fast = nums[nums[fast]]; // move 2 steps
        } while (slow != fast);

        // Step 2: Find the entrance to the cycle (duplicate number)
        slow = nums[0]; // reset slow to beginning
        while (slow != fast)
        {
            slow = nums[slow]; // move 1 step
            fast = nums[fast]; // move 1 step
        }

        return slow; // or fast — both are at the duplicate
    }

    public static int FindDuplicate(int[] nums)
    {
        ///
        /// ❌ Why it Fails the "constant space" requirement
        // You're using a HashSet<int>,
        // which grows with the number of elements (up to n),
        // so the space complexity is O(n) — not constant.
        ///
        var sets = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!sets.Add(nums[i]))
                return nums[i];
        }
        return -1;
    }
}
