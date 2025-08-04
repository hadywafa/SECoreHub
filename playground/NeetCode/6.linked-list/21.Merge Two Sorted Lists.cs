namespace NeetCode.LinkedList;

public static class P21
{
    public static void Run()
    {
        //------------------------------------------
        int[] arrList1 = [1, 2, 4];
        int[] arrList2 = [1, 3, 4];

        // int[] values = [];
        ListNode list1 = ListNode.CreateLinkedList(arrList1);
        ListNode list2 = ListNode.CreateLinkedList(arrList2);

        var result = MergeTwoLists_S2(list1, list2);
        Console.WriteLine(result);
    }

    //⁉️ 🤖
    public static ListNode MergeTwoLists_S2(ListNode? list1, ListNode? list2)
    {
        // Dummy head to simplify edge cases
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next!;
        }

        // Attach remaining nodes (only one list can have leftovers)
        current.next = list1 ?? list2;

        return dummy.next!;
    }

    public static ListNode MergeTwoLists_S1(ListNode list1, ListNode list2)
    {
        var tempList1 = new List<int>();
        var tempList2 = new List<int>();

        while (list1 != null)
        {
            tempList1.Add(list1.val);
            list1 = list1.next;
        }
        while (list2 != null)
        {
            tempList2.Add(list2.val);
            list2 = list2.next;
        }
        tempList1.AddRange(tempList2);
        var mergedArray = tempList1.Order();

        var result = ListNode.CreateLinkedList(mergedArray.ToArray());
        return result;
    }
}
