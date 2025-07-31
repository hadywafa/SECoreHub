namespace NeetCode.TwoPointer;

public class P1768
{
    public static void Run()
    {
        string word1 = "abc",
            word2 = "pqr";

        var result = MergeAlternately(word1, word2);
        Console.WriteLine(result);
    }

    public static string MergeAlternately(string word1, string word2)
    {
        var result = new List<char>();
        var maxLength = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i < maxLength; i++)
        {
            //append word1
            if (i < word1.Length)
                result.Add(word1[i]);
            //append word2
            if (i < word2.Length)
                result.Add(word2[i]);
        }
        return string.Join("", result);
    }
}
