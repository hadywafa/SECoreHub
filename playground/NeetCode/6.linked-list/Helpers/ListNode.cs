namespace NeetCode.LinkedList;

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
