namespace NeetCode.SlidingWindow;

public class P424
{
    public static void Run()
    {
        // string s = "ABAB";
        string s = "AABABBA";
        // string s = "ABBB";
        int k = 1;

        var result = CharacterReplacement_AI(s, k);
        System.Console.WriteLine(result);
    }

    //🔞
    public static int CharacterReplacement_AI(string s, int k)
    {
        // "AABABBA"
        int maxLength = 0;

        // Try using every unique letter as the "target" character
        var uniqueLetters = new HashSet<char>(s);
        foreach (char targetChar in uniqueLetters)
        {
            int left = 0; // left side of the sliding window
            int matchCount = 0; // how many times targetChar appears in the window

            // Expand window from left to right
            for (int right = 0; right < s.Length; right++)
            {
                // Count targetChar in the current window
                if (s[right] == targetChar)
                    matchCount++;

                // If the number of characters to change > k, shrink the window
                while ((right - left + 1) - matchCount > k)
                {
                    if (s[left] == targetChar)
                        matchCount--;

                    left++; // shrink from the left
                }

                // Update the result: longest valid window so far
                int currentWindowSize = right - left + 1;
                maxLength = Math.Max(maxLength, currentWindowSize);
            }
        }

        return maxLength;
    }
}
