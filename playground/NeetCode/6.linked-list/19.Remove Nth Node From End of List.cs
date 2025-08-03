namespace NeetCode.LinkedList;

public static class P19
{
    public static void Run()
    {
        int n = 2;
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);
        node1.next = node2;
        //-------------
        // int n = 2;
        // var node1 = new ListNode(1);
        // var node2 = new ListNode(2);
        // var node3 = new ListNode(3);
        // var node4 = new ListNode(4);
        // var node5 = new ListNode(5);

        // node1.next = node2;
        // node2.next = node3;
        // node3.next = node4;
        // node4.next = node5;

        //------------------------------------------
        var result = RemoveNthFromEnd(node1, n);
        System.Console.WriteLine(result);
    }

    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //linkedList to list
        var hList = new List<int>();
        while (head != null)
        {
            hList.Add(head.val);
            head = head.next;
        }

        // list to linkedList
        if (hList == null || hList.Count == 0 || n > hList.Count)
            return null;

        ListNode current = null;
        for (int j = 0; j < hList.Count; j++)
        {
            if (j == hList.Count - n)
                continue;

            var newNode = new ListNode(hList[j]);

            if (head == null)
            {
                head = newNode;
                current = head;
            }
            else
            {
                current.next = newNode;
                current = current.next;
            }
        }

        return head;
    }
}
