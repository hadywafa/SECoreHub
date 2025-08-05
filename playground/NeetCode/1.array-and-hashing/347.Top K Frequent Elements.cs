namespace NeetCode.ArraysAndHashing;

public class P347
{
    public static void Run()
    {
        // int[] nums = [1, 1, 1, 2, 2, 3];
        int[] nums = [1, 1, 3, 1, 2, 2];
        int k = 2;
        var result = TopKFrequent_1(nums, k);

        System.Console.WriteLine(result.HwToString());
    }

    public static int[] TopKFrequent_2(int[] nums, int k)
    {
        var calc = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (calc.ContainsKey(nums[i]))
            {
                calc[nums[i]]++;
            }
            else
            {
                calc.Add(nums[i], 1);
            }
        }
        return calc.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
    }

    public static int[] TopKFrequent_1(int[] nums, int k)
    {
        // Step 1: Count frequencies
        var freqMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            freqMap[num] = freqMap.TryGetValue(num, out var count) ? count + 1 : 1;
        }

        // Step 2: Use a min-heap to keep top k frequent elements
        var pq = new PriorityQueue<int, int>(); // MinHeap: lower freq = higher priority

        foreach (var entry in freqMap)
        {
            pq.Enqueue(entry.Key, entry.Value); // key=num, priority=freq

            if (pq.Count > k)
                pq.Dequeue(); // keep only top k
        }

        // Step 3: Build result
        var result = new List<int>();
        while (pq.Count > 0)
        {
            result.Add(pq.Dequeue());
        }

        // // Optional: reverse for descending order (not required in problem)
        // result.Reverse();
        return result.ToArray();
    }
}
