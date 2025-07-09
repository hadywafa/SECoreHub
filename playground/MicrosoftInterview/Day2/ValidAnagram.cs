namespace MicrosoftInterview;

public partial class Solution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var dictCharDuplicateDiffCount = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            // pointer 1 to first arrayChar =>
            // is current char NOT spotted in dictCharDuplicateDiffCount?

            //init missing key
            if (!dictCharDuplicateDiffCount.ContainsKey(s[i]))
            {
                dictCharDuplicateDiffCount[s[i]] = 0;
            }

            if (!dictCharDuplicateDiffCount.ContainsKey(t[i]))
            {
                dictCharDuplicateDiffCount[t[i]] = 0;
            }

            //===============================================================
            if (dictCharDuplicateDiffCount.GetValueOrDefault(s[i], 0) != 0)
            {
                dictCharDuplicateDiffCount[s[i]]--;
            }



            //===============================================================
            // pointer 2 to second arrayChar =>  
            // is current char NOT spotted in dictCharDuplicateDiffCount?
            if (dictCharDuplicateDiffCount.GetValueOrDefault(t[i], 0) != 0)
            {
                dictCharDuplicateDiffCount[t[i]]--;
            }

        }

        // duplicate Difference == 0 == same char with possible different order == target
        // else unique and not the same;
        foreach (var value in dictCharDuplicateDiffCount.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
