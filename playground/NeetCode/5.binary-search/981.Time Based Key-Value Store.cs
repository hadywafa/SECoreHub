using System.Data;
using System.IO.Pipelines;

namespace NeetCode.BinarySearch;

public class P981
{
    public static void Run()
    {
        TimeMap timeMap = new TimeMap();
        timeMap.Set("foo", "bar", 1); // store the key "foo" and value "bar" along with timestamp = 1.
        var x1 = timeMap.Get("foo", 1); // return "bar"
        var x2 = timeMap.Get("foo", 3); // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
        timeMap.Set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
        var x3 = timeMap.Get("foo", 4); // return "bar2"
        var x4 = timeMap.Get("foo", 5); // return "bar2"
    }
}

public class TimeMap
{
    private Dictionary<string, List<(int timestamp, string value)>> dict;

    public TimeMap()
    {
        dict = new Dictionary<string, List<(int, string)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!dict.ContainsKey(key))
            dict[key] = new List<(int, string)>();

        dict[key].Add((timestamp, value)); // Always in increasing order
    }

    public string Get(string key, int timestamp)
    {
        if (!dict.ContainsKey(key))
            return "";

        var entries = dict[key];
        int left = 0,
            right = entries.Count - 1;
        string result = "";

        // Binary search to find largest timestamp <= given timestamp
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (entries[mid].timestamp <= timestamp)
            {
                result = entries[mid].value;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return result;
    }
}
