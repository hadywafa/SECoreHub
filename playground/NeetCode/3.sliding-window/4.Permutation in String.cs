namespace NeetCode.SlidingWindow;

public class P4
{
    public static void Run()
    {
        string s1 = "ab";
        string s2 = "eidbaooo";
        // string s1 = "ab", s2 = "eidboaoo";
        // string s1 = "adc", s2 = "dcda";
        // string s1 = "dinitrophenylhydrazine", s2 = "acetylphenylhydrazine";
        var result = CheckInclusion(s1, s2);
        System.Console.WriteLine(result);
    }

    //😎🐌
    public static bool CheckInclusion(string s1, string s2)
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
}
