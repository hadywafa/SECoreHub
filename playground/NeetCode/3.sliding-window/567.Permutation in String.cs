namespace NeetCode.SlidingWindow;

public class P567
{
    public static void Run()
    {
        string s1 = "ab";
        string s2 = "eidbaooo";
        // string s1 = "ab", s2 = "eidboaoo";
        // string s1 = "adc", s2 = "dcda";
        // string s1 = "dinitrophenylhydrazine", s2 = "acetylphenylhydrazine";
        var result = CheckInclusion_1(s1, s2);
        System.Console.WriteLine(result);
    }

    public static bool CheckInclusion_1(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        var targetFreq = BuildFrequencyMap(s1);
        var windowFreq = new Dictionary<char, int>();

        int windowSize = s1.Length;

        for (int i = 0; i < s2.Length; i++)
        {
            char c = s2[i];
            windowFreq[c] = windowFreq.GetValueOrDefault(c) + 1;

            // Shrink window when size exceeds
            if (i >= windowSize)
            {
                char leftChar = s2[i - windowSize];
                if (windowFreq[leftChar] == 1)
                    windowFreq.Remove(leftChar);
                else
                    windowFreq[leftChar]--;
            }

            // Compare the frequency maps
            if (AreEqual(windowFreq, targetFreq))
                return true;
        }

        return false;
    }

    // Helper to build frequency dictionary
    private static Dictionary<char, int> BuildFrequencyMap(string s)
    {
        var freq = new Dictionary<char, int>();
        foreach (char c in s)
            freq[c] = freq.GetValueOrDefault(c) + 1;
        return freq;
    }

    // Helper to compare two frequency dictionaries
    private static bool AreEqual(Dictionary<char, int> a, Dictionary<char, int> b)
    {
        if (a.Count != b.Count)
            return false;

        foreach (var pair in a)
        {
            if (!b.ContainsKey(pair.Key) || b[pair.Key] != pair.Value)
                return false;
        }

        return true;
    }

    public static bool CheckInclusion_AI(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;
        Span<int> s1Count = stackalloc int[26];
        Span<int> s2Count = stackalloc int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
        }
        for (int i = 0; i < s2.Length; i++)
        {
            s2Count[s2[i] - 'a']++;
            if (i >= s1.Length)
            {
                s2Count[s2[i - s1.Length] - 'a']--;
            }
            if (s1Count.SequenceEqual(s2Count))
                return true;
        }
        return false;
    }

    //😎🐌
    public static bool CheckInclusion_2(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;
        var s1SortedStr = string.Join("", s1.Order().ToArray());
        var window = new List<char>();
        int l = 0;
        for (int r = 0; r < s2.Length; r++)
        {
            if (window.Count == s1.Length)
            {
                var str = string.Join("", window.Order());
                if (str == s1SortedStr)
                    return true;
                else
                {
                    window.Remove(s2[l]);
                    l++;
                }
            }
            window.Add(s2[r]);
        }
        var lastStr = string.Join("", window.Order());
        if (lastStr == s1SortedStr)
            return true;
        return false;
    }
}
