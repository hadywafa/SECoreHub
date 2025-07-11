using System.Data;

namespace DSA.BasicDataStructure;

public class LearnHashTable
{
    public static void Run()
    {
        var result1 = CustomHashTable.FindFirstNonRepeatingChar("hhaady waafa");
        System.Console.WriteLine(result1);
        //---------------
        var result2 = CustomHashTable.FindFirstRepeatingChar("hhaady waafa");
        System.Console.WriteLine(result2);
        //---------------
        var uniqueArray = CustomHashTable.RemoveDuplication([1, 1, 2, 2, 4, 5]);
        // uniqueArray?.PrintValues();
    }
}

//-----------------------------------------------

public class CustomHashTable
{
    public static char FindFirstNonRepeatingChar(string str)
    {
        var dictionary = new Dictionary<char, int>();
        // create char-count key-pair
        foreach (var item in str)
        {
            int charCount = 0;
            if (dictionary.ContainsKey(item))
                dictionary.TryGetValue(item, out charCount);
            dictionary[item] = charCount + 1;
        }

        //get first non-repeated
        foreach (var item in str)
        {
            dictionary.TryGetValue(item, out int charCount);
            if (charCount == 1)
                return item;
        }
        return char.MinValue;
    }

    public static int[] RemoveDuplication(int[] duplicatedArray)
    {
        return new HashSet<int>(duplicatedArray).ToArray();
    }

    public static char FindFirstRepeatingChar(string str)
    {
        #region  Solution 1
        // var dictionary = new Dictionary<char, int>();
        // foreach (var item in str)
        // {
        //     int charCount = 0;
        //     if (dictionary.ContainsKey(item))
        //         dictionary.TryGetValue(item, out charCount);
        //     dictionary[item] = charCount + 1;
        // }
        // foreach (var item in str)
        // {
        //     dictionary.TryGetValue(item, out int charCount);
        //     if (charCount > 1) return item;
        // }
        // return char.MinValue;
        #endregion

        #region Solution 2
        var uniqueArray = new HashSet<int>();
        foreach (var item in str)
        {
            if (uniqueArray.Contains(item))
                return item;
            uniqueArray.Add(item);
        }
        return char.MinValue;
        #endregion
    }
}
