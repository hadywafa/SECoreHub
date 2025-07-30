namespace NeetCode.ArraysAndHashing;

public class P706
{
    public static void Run()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        myHashMap.Get(1); // return 1, The map is now [[1,1], [2,2]]
        myHashMap.Get(3); // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        myHashMap.Get(2); // return 1, The map is now [[1,1], [2,1]]
        myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
        myHashMap.Get(2); // return -1 (i.e., not found), The map is now [[1,1]]
    }
}

public class MyHashMap
{
    private int[] map;

    public MyHashMap()
    {
        map = new int[1000001];
        for (int i = 0; i < map.Length; i++)
        {
            map[i] = -1;
        }
    }

    public void Put(int key, int value)
    {
        map[key] = value;
    }

    public int Get(int key)
    {
        return map[key];
    }

    public void Remove(int key)
    {
        map[key] = -1;
    }
}
