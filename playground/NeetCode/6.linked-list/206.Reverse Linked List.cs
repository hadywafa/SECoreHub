namespace NeetCode.LinkedList;

public static class P206
{
    public static void Run()
    {
        //------------------------------------------
        int[] values = [1, 2, 3, 4, 5];
        // int[] values = [];
        var head = ListNode.CreateLinkedList(values.Reverse().ToArray());
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

        var result = ListNode.CreateLinkedList(values.ToArray());
        return result;
    }
}
