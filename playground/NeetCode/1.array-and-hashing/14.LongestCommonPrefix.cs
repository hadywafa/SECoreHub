namespace NeetCode.ArraysAndHashing;

public class P14
{
    public static void Run()
    {
        string[] strs = ["flower", "flow", "flight"];

        var result = LongestCommonPrefix(strs);
        System.Console.WriteLine(result);
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        return Sol_2(strs);
    }

    public static string Sol_1(string[] strs)
    {
        var target = strs.Select(x => new { item = x, length = x.Length })
            .OrderByDescending(x => x.length)
            .FirstOrDefault();

        if (target == null)
            return "";

        string prefix = target.item;
        int length = target.length;
        for (int i = 0; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix) && length != 0)
            {
                length--;
                prefix = prefix.Substring(0, length);
            }
        }
        return prefix;
    }

    public static string Sol_2(string[] strs) {
        var prefix = strs[0];

        for(int i = 1; i < strs.Length; i++) {
            while(!strs[i].StartsWith(prefix) && prefix.Length != 0)
                prefix = prefix.Substring(0, prefix.Length - 1);
        }

        return prefix;
    }

    public static string Sol_3(string[] strs)
    {
        var firstItem = strs[0];
        var lastIndex = firstItem.Length;
        string result;

    mark:
        result = firstItem.Substring(0, lastIndex);
        for (int i = 1; i < strs.Length; i++)
        {
            if (!strs[i].StartsWith(result))
            {
                if (lastIndex == 0)
                    return result;
                else
                {
                    lastIndex--;
                    goto mark;
                }
            }
        }

        return result;
    }
}
