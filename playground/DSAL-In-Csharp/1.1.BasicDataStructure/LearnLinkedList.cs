using System.Drawing;

namespace DSAL.Part1;

public class LearnLinkedList
{
    public LearnLinkedList()
    {
        //built-in implementation
        var builtInLinkedList = new LinkedList<int>();

        // custom implementation

        var list = new CustomLinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        list.PrintList();
        System.Console.WriteLine(list.IndexOf(20));
        System.Console.WriteLine(list.Contains(50));
        list.Reverse();
        list.PrintList();
    }
}

//-----------------------------------------------

public class CustomLinkedList<T>
{
    private Node<T>? Head { get; set; }
    private Node<T>? Tail { get; set; }
    private int Count { get; set; }

    //-------------------------------------------------
    private bool IsEmpty()
    {
        return Head == null;
    }

    private Node<T>? GetBefore(Node<T> node)
    {
        if (IsEmpty() || Head == Tail)
            return null;
        var current = Head;
        while (current != null)
        {
            if (current.Next == node)
                return current;
            current = current.Next;
        }
        return null;
    }

    public void PrintList()
    {
        var current = Head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    //-------------------------------------------------
    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);

        if (IsEmpty())
            Head = Tail = newNode;
        else
        {
            //point newNode as next for last-node
            Tail!.Next = newNode;
            //update tail reference
            Tail = newNode;
            //update count
            Count++;
        }
    }

    public void AddFirst(T value)
    {
        var newNode = new Node<T>(value);

        if (IsEmpty())
            Tail = Head = newNode;
        else
        {
            //point first-node as next for newNode
            newNode.Next = Head;
            //update head reference
            Head = newNode;
            //update count
            Count++;
        }
    }

    public int IndexOf(T value)
    {
        int index = 0;
        var current = Head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
                return index;
            index++;
            current = current.Next;
        }
        return -1; // Not found
    }

    public bool Contains(T value)
    {
        return IndexOf(value) != -1; // Not found
    }

    public void RemoveFirst()
    {
        if (IsEmpty())
            throw new Exception();

        var secondNode = Head?.Next;
        if (secondNode != null)
        {
            //remove first-node link
            Head!.Next = null;
            //update Head reference
            Head = secondNode;
            //update count
            Count--;
        }
    }

    public void RemoveLast()
    {
        if (IsEmpty())
            throw new Exception();
        //get before-last-node
        var beforeLastNode = GetBefore(Tail!);
        if (beforeLastNode != null)
        {
            //remove last-node link
            beforeLastNode.Next = null;
            //update tail reference
            Tail = beforeLastNode;
            //update count
            Count--;
        }
    }

    public T[] ToArray()
    {
        var current = Head;
        var array = new T[Count];
        var index = 0;
        while (current != null)
        {
            array[index++] = current.Value;
            current = current.Next;
        }
        return array;
    }

    /// <summary>
    /// Reverses the order of elements in the linked list.
    /// </summary>
    public void Reverse()
    {
        // Check if the linked list is empty
        if (IsEmpty())
            return;

        // Initialize variables to keep track of nodes during reversal
        var previous = Head;
        var current = Head.Next;

        // Traverse through the list and reverse the links
        while (current != null)
        {
            // Save the next node in the original list
            var next = current.Next;

            // Reverse the link: make the current node point to the previous node
            current.Next = previous;

            // Move to the next nodes in the original and reversed lists
            previous = current;
            current = next;
        }

        // Adjust Head and Tail after reversal
        Tail = Head; // The original Head is now the new Tail
        Tail.Next = null; // Set the new Tail's Next to null to indicate the end of the list
        Head = previous; // The last node in the original list is now the new Head
    }
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}
