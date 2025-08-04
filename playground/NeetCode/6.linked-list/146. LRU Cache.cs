namespace NeetCode.LinkedList;

public static class P146
{
    public static void Run()
    {
        LRUCache lRUCache = new LRUCache(2);
        lRUCache.Put(1, 1); // cache is {1=1}
        lRUCache.Put(2, 2); // cache is {1=1, 2=2}
        var x1 = lRUCache.Get(1); // return 1
        lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        var x2 = lRUCache.Get(2); // returns -1 (not found)
        lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        var x3 = lRUCache.Get(1); // return -1 (not found)
        var x4 = lRUCache.Get(3); // return 3
        var x5 = lRUCache.Get(4); // return 4
    }
}

public class LRUCache
{
    private Dictionary<int, LinkedListNode<(int key, int value)>> cache;

    //LRU => order my least used async.
    private LinkedList<(int key, int value)> order;
    private int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        this.cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        this.order = new LinkedList<(int key, int value)>();
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key))
            return -1;
        var node = cache[key];
        order.Remove(node);
        order.AddLast(node);
        return node.Value.value;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            var node = cache[key];
            order.Remove(node);
            node.Value = (key, value);
            order.AddLast(node);
        }
        else
        {
            if (cache.Count == capacity)
            {
                var lru = order.First.Value;
                cache.Remove(lru.key);
                order.RemoveFirst();
            }
            var newNode = new LinkedListNode<(int key, int value)>((key, value));
            order.AddLast(newNode);
            cache[key] = newNode;
        }
    }
}
