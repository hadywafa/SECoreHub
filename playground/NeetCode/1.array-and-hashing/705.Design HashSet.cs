namespace NeetCode.ArraysAndHashing;

public class P705
{
    public static void Run()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1); // set = [1]
        myHashSet.Add(2); // set = [1, 2]
        bool x1 = myHashSet.Contains(1); // return True
        bool x2 = myHashSet.Contains(3); // return False, (not found)
        myHashSet.Add(2); // set = [1, 2]
        bool x3 = myHashSet.Contains(2); // return True
        myHashSet.Remove(2); // set = [1]
        bool x4 = myHashSet.Contains(2); // return False, (already removed)
    }
}

public class MyHashSet
{
    Dictionary<int, int> arr;

    public MyHashSet()
    {
        arr = new Dictionary<int, int>();
    }

    public void Add(int key)
    {
        if (!Contains(key))
        {
            arr[key] = key;
        }
    }

    public void Remove(int key)
    {
        arr.Remove(key);
    }

    public bool Contains(int key)
    {
        return arr.ContainsKey(key);
    }
}
