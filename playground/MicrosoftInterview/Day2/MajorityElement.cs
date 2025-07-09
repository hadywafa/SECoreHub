namespace MicrosoftInterview;

public partial class Solution
{
    public static int MajorityElement(int[] nums)
    {
        var dictNumberCount = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictNumberCount.ContainsKey(nums[i]))
                dictNumberCount[nums[i]]++;
            else
                dictNumberCount[nums[i]] = 1;
        }
        var result = dictNumberCount
            .Where(x => x.Value > nums.Length / 2)
            .Select(x => x.Key)
            .FirstOrDefault();
        return result;
    }
}
