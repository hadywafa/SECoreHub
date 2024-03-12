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

    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);

        if (Head == null)
            Head = Tail = newNode;
        else
        {
            //add the newNode after last node
            Tail.Next = newNode;
            //update last node to be newNode
            Tail = newNode;
        }

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