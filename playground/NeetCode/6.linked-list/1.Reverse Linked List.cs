namespace NeetCode.LinkedList;

public static class P1
{
    public static void Run()
    {
        //------------------------------------------
        int[] values = [1, 2, 3, 4, 5];
        var head = CreateLinkedList(values.Reverse().ToArray());
        var result = ReverseList_Solution1(head);
        Console.WriteLine(head);
    }

    public static ListNode ReverseList_Solution1(ListNode head)
    {
        // var reversedList = new ListNode(head.val);

        ListNode? next = null;
        ListNode? current = null;
        while (true)
        {
            current.next = current.next = new ListNode(current.val);

            next = next.next;
            if (current.next == null)
            {
                break;
            }
        }

        return next;
    }

    public static ListNode CreateLinkedList(int[] values)
    {
        ListNode? head = null;
        ListNode? current = null;
        foreach (int val in values)
        {
            if (head == null)
            {
                head = new ListNode(val);
                current = head;
            }
            else
            {
                if (current != null)
                {
                    current.next = current.next = new ListNode(val);

                    current = current.next;
                }
            }
        }
        return head;
    }
}

//   Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
