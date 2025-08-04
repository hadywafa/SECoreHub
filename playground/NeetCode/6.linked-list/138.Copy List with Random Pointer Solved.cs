using System.Numerics;

namespace NeetCode.LinkedList;

public static class P138
{
    public static void Run()
    {
        var firstNode1 = new Node(2);
        var firstNode2 = new Node(13);
        var firstNode3 = new Node(11);
        var firstNode4 = new Node(10);
        var firstNode5 = new Node(1);
        firstNode1.next = firstNode2;
        firstNode2.next = firstNode3;
        firstNode3.next = firstNode4;
        firstNode4.next = firstNode5;

        firstNode1.random = null;
        firstNode2.random = firstNode1;
        firstNode3.random = firstNode5;
        firstNode4.random = firstNode3;
        //------------------------------------------
        var result = CopyRandomList(firstNode1);
        System.Console.WriteLine(result);
    }

    public static Node CopyRandomList(Node head)
    {
        //Hash to map random objects;
        var mapNodes = new Dictionary<Node, Node>();

        var oldHead = head;
        Node newHead = null;
        Node current = null;
        while (oldHead != null)
        {
            var newNode = new Node(oldHead.val);

            if (newHead == null)
            {
                newHead = newNode;
                current = newHead;
            }
            else
            {
                current.next = newNode;
                current = current.next;
            }

            mapNodes.Add(oldHead, newNode);
            oldHead = oldHead.next;
        }
        oldHead = head;
        while (oldHead != null)
        {
            if (oldHead.random != null)
            {
                mapNodes[oldHead].random = mapNodes[oldHead.random];
            }
            oldHead = oldHead.next;
        }

        return newHead;
    }
}
