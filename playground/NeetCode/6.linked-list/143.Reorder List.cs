namespace NeetCode.LinkedList;

public static class P143
{
    public static void Run()
    {
        var node1 = new ListNode(1);
        var node2 = new ListNode(2);
        var node3 = new ListNode(3);
        var node4 = new ListNode(4);

        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        //------------------------------------------
        ReorderList(node1);
        System.Console.WriteLine();
    }

    public static void ReorderList(ListNode head)
    {
        // [1, 2, 3, 4]
        // [1, 4, 2, 3]
        var test = head;
        var list = new List<int>();
        // 1.get node values as list
        while (test != null)
        {
            list.Add(test.val);
            test = test.next;
        }
        var newList = new List<int>();
        int l = 0;
        int r = list.Count - 1;
        // 2.define new list that have same patter
        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 != 0)
            {
                newList.Add(list[r]);
                r--;
            }
            else
            {
                newList.Add(list[l]);
                l++;
            }
        }
        int o = 0;
        //3.update main linkedlist
        while (head != null)
        {
            head.val = newList[o];
            head = head.next;
            o++;
        }
    }
}
