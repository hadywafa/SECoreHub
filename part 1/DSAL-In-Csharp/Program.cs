using DSAL;

#region Arrays Data Structure
// int[] array1 = new int[3];
// int[] array2 = new int[] { 1, 2, 4 };
// int[] array3 = [1, 2, 4];
// string result = "[" + string.Join(", ", array3.Select(n => n.ToString())) + "]";
// System.Console.WriteLine(string.Join(", ", result));
// Array.Copy(array3, array2, array3.Length);
// Array.Copy(array3, 2, array3, 2 + 1, array3.Length - 2);
#endregion

#region LinkedList Data Structure
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

#region   Stacks
var result1 = HwStack.Reverse("hady");
System.Console.WriteLine(result1);
var result2 = HwStack.IsBalancedV1("( 1 + 1 ))");
System.Console.WriteLine(result2);
var result3 = HwStack.IsBalancedV2("(({ 1 + 1}))");
System.Console.WriteLine(result3);
#endregion