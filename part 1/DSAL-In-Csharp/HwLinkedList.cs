namespace DSAL;
public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}
public class HwLinkedList<T>
{
    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }
    //-------------------------------------------------
    private bool IsEmpty()
    {
        return Head == null;
    }
    //-------------------------------------------------
    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);

        if (IsEmpty())
            Head = Tail = newNode;
        else
        {
            //add the newNode after last node
            //point newNode as next-node for current-last-node 
            Tail.Next = newNode;
            //update last node of linkedList
            Tail = newNode;
        }

    }
    public void AddFirst(T value)
    {
        var newNode = new Node<T>(value);

        if (IsEmpty())
            Tail = Head = newNode;
        else
        {
            //point current-first-node as next-node for newNode
            newNode.Next = Head;
            //update first node of linkedList
            Head = newNode;
        }
    }

    public int IndexOf(T value)
    {
        int index = 0;
        var current = Head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value)) return index;
            index++;
            current = current.Next;
        }
        return -1;// Not found
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
}