
using System.Runtime.InteropServices;

namespace DSAL;
public class HwQueue<T>
{
    private T[] array;
    private int front;
    private int rear;

    public HwQueue(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0");

        array = new T[capacity];
        front = 0;
        rear = -1;
    }

    public void Enqueue(T item)
    {
        if (rear == array.Length - 1)
        {
            // Queue is full, resize the array or throw an exception
            Console.WriteLine("Queue overflow!");
            return;
        }

        array[++rear] = item;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            // Queue is empty, throw an exception or return a default value
            Console.WriteLine("Queue underflow!");
            return default(T);
        }

        T item = array[front++];
        if (front > rear)
        {
            // Reset front and rear when the last element is dequeued
            front = 0;
            rear = -1;
        }

        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            // Queue is empty, throw an exception or return a default value
            Console.WriteLine("Queue is empty!");
            return default(T);
        }

        return array[front];
    }

    public bool IsEmpty()
    {
        return front > rear;
    }

    public int Count
    {
        get { return rear - front + 1; }
    }
    //----------------------------------------------------------------
    public static Queue<T> Reverse(Queue<T> queue)
    {
        var stack = new Stack<T>();

        while (queue.Count > 0)
            stack.Push(queue.Dequeue());
        while (stack.Count > 0)
            queue.Enqueue(stack.Pop());
        return queue;
    }
    public static string QueueToString(Queue<T> queue)
    {
        return "[" + string.Join(", ", queue) + "]";
    }
}