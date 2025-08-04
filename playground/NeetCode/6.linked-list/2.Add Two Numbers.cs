using System.Numerics;

namespace NeetCode.LinkedList;

public static class P2
{
    public static void Run()
    {
        var firstNode1 = new ListNode(2);
        var firstNode2 = new ListNode(4);
        var firstNode3 = new ListNode(3);
        firstNode1.next = firstNode2;
        firstNode2.next = firstNode3;

        var secondNode1 = new ListNode(5);
        var secondNode2 = new ListNode(6);
        var secondNode3 = new ListNode(4);
        secondNode1.next = secondNode2;
        secondNode2.next = secondNode3;
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
        var result = AddTwoNumbers(firstNode1, secondNode1);
        System.Console.WriteLine(result);
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var list1 = new Stack<string>();
        while (l1 != null)
        {
            list1.Push(l1.val.ToString());
            l1 = l1.next;
        }

        BigInteger num1 = BigInteger.Parse(string.Join("", list1));

        var list2 = new Stack<string>();
        while (l2 != null)
        {
            list2.Push(l2.val.ToString());
            l2 = l2.next;
        }

        BigInteger num2 = BigInteger.Parse(string.Join("", list2));

        string sum = (num1 + num2).ToString();

        ListNode head = null;
        ListNode current = null;

        for (int i = sum.Length - 1; i >= 0; i--)
        {
            var newNode = new ListNode(int.Parse(sum[i].ToString()));

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
