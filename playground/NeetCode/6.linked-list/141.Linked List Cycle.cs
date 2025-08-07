namespace NeetCode.LinkedList;

public static class P141
{
    public static void Run()
    {
        var node1 = new ListNode(3);
        var node2 = new ListNode(2);
        var node3 = new ListNode(0);
        var node4 = new ListNode(-4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2; // cycle here
        //------------------------------------------

        var result = HasCycle_S1(node1);
        Console.WriteLine(result);
    }

    public static bool HasCycle_S1(ListNode? head)
    {
        var bag = new HashSet<ListNode>();
        int pos = -1;
        while (true)
        {
            if (head == null)
            {
                System.Console.WriteLine(pos);
                return false;
            }
            else if (bag.Contains(head))
            {
                System.Console.WriteLine(pos);
                return true;
            }
            else
            {
                pos++;
                bag.Add(head);
                head = head.next;
            }
        }
    }
}
