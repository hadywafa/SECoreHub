namespace NeetCode.SlidingWindow;

public class P2
{
    public static void Run()
    {
        string s = "abcbb";
        // string s = "pwwkew";
        // string s = " ";
        // string s = "dvdf";
        var result = LengthOfLongestSubstring(s);
        System.Console.WriteLine(result);
    }

    public static int LengthOfLongestSubstring(string s)
    {
        // error when s = "dvdf"
        HashSet<char> charSet = new HashSet<char>();
        int l = 0;
        int res = 0;

        for (int r = 0; r < s.Length; r++)
        {
            while (charSet.Contains(s[r]))
            {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, (r - l) + 1);
        }
        return res;
    }

    public static int LengthOfLongestSubstring_OLD(string s)
    {
        // error when s = "dvdf"
        var uniquePattern = new Dictionary<string, int>();
        int lengthCount = 0;
        List<char> tempStr = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (!tempStr.Contains(currentChar))
            {
                tempStr.Add(currentChar);
                lengthCount++;
            }
            else
            {
                string result = string.Join("", tempStr);
                if (!uniquePattern.ContainsKey(result))
                {
                    uniquePattern.Add(result, lengthCount);
                }
                lengthCount = 1;
                tempStr = new List<char> { currentChar };
            }
        }

        string lastResult = string.Join("", tempStr);
        if (!uniquePattern.ContainsKey(lastResult))
        {
            uniquePattern.Add(lastResult, lengthCount);
        }

        return uniquePattern.OrderByDescending(x => x.Value).Select(x => x.Value).FirstOrDefault();
    }
}
