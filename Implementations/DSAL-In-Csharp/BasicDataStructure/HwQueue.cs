using System.Runtime.InteropServices;

namespace DSAL.Part1;

public class HwQueue<T>
{
    private T[] array;
    private int front;
    private int rear;
    private int capacity;
    public int Count
    {
        get
        {
            if (IsEmpty())
            {
                return 0;
            }
            else if (front <= rear)
            {
                return rear - front + 1;
            }
            else
            {
                return capacity - front + rear + 1;
            }
        }
    }

    public HwQueue(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0");

        this.capacity = capacity;
        array = new T[capacity];
        front = -1;
        rear = -1;
    }

    public void Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue is full. Cannot enqueue.");
            return;
        }

        if (IsEmpty())
        {
            front = 0;
        }

        rear = (rear + 1) % capacity;
        array[rear] = item;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot dequeue.");
            return default;
        }

        T item = array[front];
        array[front] = default;

        if (front == rear)
        {
            // Reset front and rear when the last element is dequeued
            front = -1;
            rear = -1;
        }
        else
        {
            front = (front + 1) % capacity;
        }

        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty. Cannot peek.");
            return default;
        }

        return array[front];
    }

    public bool IsEmpty()
    {
        return front == -1 && rear == -1;
    }

    public bool IsFull()
    {
        return (rear + 1) % capacity == front;
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
