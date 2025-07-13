namespace NeetCode.LinkedList;

public static class P1
{
    public static void Run()
    {
        //------------------------------------------
        int[] values = [1, 2, 3, 4, 5];
        // int[] values = [];
        var head = CreateLinkedList(values.Reverse().ToArray());
        var result = ReverseList_Solution2(head);
        Console.WriteLine(result);
    }

    // ⁉️🤖
    public static ListNode ReverseList_Solution2(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    // ✅😎
    public static ListNode ReverseList_Solution1(ListNode? head)
    {
        // var reversedList = new ListNode(head.val);

        // ListNode? next = null;
        if (head == null)
            return head;

        Stack<int> values = [];
        while (head != null)
        {
            values.Push(head.val);
            head = head.next;
        }

        var result = CreateLinkedList(values.ToArray());
        return result;
    }

    private static ListNode CreateLinkedList(int[] values)
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
