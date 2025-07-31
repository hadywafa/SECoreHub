namespace NeetCode.Stack;

// Implement Stack using Queues
public class P225
{
    public static void Run()
    {
        MyStack myStack = new MyStack();
        //-----------------------------------
        // myStack.Push(1);
        // myStack.Push(2);
        // var x1 = myStack.Top(); // return 2
        // var x2 = myStack.Pop(); // return 2
        // myStack.Empty(); // return False
        //-----------------------------------
        myStack.Push(2);
        var x1 = myStack.Pop(); // return 2
        myStack.Empty(); // return False
        //-----------------------------------
    }
}

public class MyStack
{
    Queue<int> queue;

    public MyStack()
    {
        queue = new Queue<int>();
    }

    public void Push(int x)
    {
        queue.Enqueue(x);
    }

    public bool Empty()
    {
        return queue.Count == 0;
    }

    public int Pop()
    {
        var newQueue = new Queue<int>();
        int lastItem = -1;
        int length = queue.Count;
        for (int i = 0; i < length; i++)
        {
            var item = queue.Dequeue();
            if (i <= length - 2)
            {
                newQueue.Enqueue(item);
            }
            lastItem = item;
        }
        queue = newQueue;
        return lastItem;
    }

    public int Top()
    {
        var newQueue = new Queue<int>();
        int length = queue.Count;
        int lastItem = -1;
        for (int i = 0; i < length; i++)
        {
            var item = queue.Dequeue();
            newQueue.Enqueue(item);
            lastItem = item;
        }
        queue = newQueue;
        return lastItem;
    }
}
