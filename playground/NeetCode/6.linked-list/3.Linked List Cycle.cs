namespace NeetCode.LinkedList;

public static class P3
{
    public static void Run()
    {
        //------------------------------------------
        int[] arrHead = [3, 2, 0, -4];

        // int[] values = [];
        ListNode head = ListNode.CreateLinkedList(arrHead);

        var result = HasCycle_S1(head);
        Console.WriteLine(result);
    }

    public static bool HasCycle_S1(ListNode head)
    {
        return true;
    }
    
}