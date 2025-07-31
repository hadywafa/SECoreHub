namespace NeetCode.Stack;

// Implement Queue using Stacks
public class P232
{
    public static void Run()
    {
        MyQueue myQueue = new MyQueue();
        myQueue.Push(1); // queue is: [1]
        myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
        int x1 = myQueue.Peek(); // return 1
        int x2 = myQueue.Pop(); // return 1, queue is [2]
        myQueue.Empty(); // return false
    }
}

public class MyQueue
{
    Stack<int> stack;

    public MyQueue()
    {
        stack = new Stack<int>();
    }

    public void Push(int x)
    {
        stack.Push(x);
    }

    public int Pop()
    {
        int length = stack.Count;
        int lastItem = -1;
        var newStack = new Stack<int>();

        for (int i = 0; i < length; i++)
        {
            var tmp = stack.Pop();
            newStack.Push(tmp);
        }
        lastItem = newStack.Pop();

        stack = newStack;
        length = stack.Count;
        newStack = new Stack<int>();
        for (int i = 0; i < length; i++)
        {
            var tmp = stack.Pop();
            newStack.Push(tmp);
        }
        stack = newStack;
        return lastItem;
    }

    public int Peek()
    {
        int length = stack.Count;
        int lastItem = -1;
        var newStack = new Stack<int>();

        for (int i = 0; i < length; i++)
        {
            lastItem = stack.Pop();
            newStack.Push(lastItem);
        }

        stack = newStack;
        newStack = new Stack<int>();
        for (int i = 0; i < length; i++)
        {
            var tmp = stack.Pop();
            newStack.Push(tmp);
        }
        stack = newStack;
        return lastItem;
    }

    public bool Empty()
    {
        return stack.Count == 0;
    }
}
