using DSAL.Part1;

#region Array
// int[] array1 = new int[3];
// int[] array2 = new int[] { 1, 2, 4 };
// int[] array3 = [1, 2, 4];
// string result = "[" + string.Join(", ", array3.Select(n => n.ToString())) + "]";
// System.Console.WriteLine(string.Join(", ", result));
// Array.Copy(array3, array2, array3.Length);
// Array.Copy(array3, 2, array3, 2 + 1, array3.Length - 2);
#endregion

#region LinkedList
//built-in implementation

// var builtInLinkedList = new LinkedList<int>();
//custom implementation
// var list = new HwLinkedList<int>();
// list.AddLast(10);
// list.AddLast(20);
// list.AddLast(30);
// list.PrintList();
// System.Console.WriteLine(list.IndexOf(20));
// System.Console.WriteLine(list.Contains(50));
// list.Reverse();
// list.PrintList();
#endregion

#region Stacks
//// ====================== custom implementation =========================
// HwStack<int> myStack = new HwStack<int>(5);

// myStack.Push(10);
// myStack.Push(20);
// myStack.Push(30);

// Console.WriteLine("Top of the stack: " + myStack.Peek());
// Console.WriteLine("Stack count: " + myStack.Count);

// while (!myStack.IsEmpty())
// {
//     Console.WriteLine("Popped: " + myStack.Pop());
// }
//// ========================== built-in ==================================
// var result1 = HwStack.Reverse("hady");
// System.Console.WriteLine(result1);
// var result2 = HwStack.IsBalancedV1("( 1 + 1 ))");
// System.Console.WriteLine(result2);
// var result3 = HwStack.IsBalancedV2("(({ 1 + 1}))");
// System.Console.WriteLine(result3);
#endregion

#region Queue  
// ====================== custom implementation =========================
// var myQueue = new HwQueue<int>(5);

// myQueue.Enqueue(10);
// myQueue.Enqueue(20);
// myQueue.Enqueue(30);

// Console.WriteLine("Front of the queue: " + myQueue.Peek());
// Console.WriteLine("Queue count: " + myQueue.Count);

// while (!myQueue.IsEmpty())
// {
//     Console.WriteLine("Dequeued: " + myQueue.Dequeue());
// }
// ========================== built-in ==================================
// var queue = new Queue<int>();

// queue.Enqueue(10);
// queue.Enqueue(20);
// queue.Enqueue(30);
// System.Console.WriteLine(HwQueue<int>.QueueToString(queue));

// var result = HwQueue<int>.Reverse(queue);
// System.Console.WriteLine(HwQueue<int>.QueueToString(queue));
#endregion

#region HashTables
var result1 = HwHashTables.FindFirstNonRepeatingChar("hhaady waafa");
System.Console.WriteLine(result1);
//---------------
var result2 = HwHashTables.FindFirstRepeatingChar("hhaady waafa");
System.Console.WriteLine(result2);
//---------------
var uniqueArray = HwHashTables.RemoveDuplication([1, 1, 2, 2, 4, 5]);
uniqueArray.PrintValues();
#endregion