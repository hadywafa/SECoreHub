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
using DSAL;

var builtInLinkedList = new LinkedList<int>();
//custom implementation
var list = new HwLinkedList<int>();
list.AddLast(10);
list.AddLast(20);
list.AddLast(30);
list.PrintList();
System.Console.WriteLine(list.IndexOf(20));
System.Console.WriteLine(list.Contains(50));
list.RemoveFirst();
list.RemoveFirst();
list.RemoveFirst();
list.RemoveFirst();
list.PrintList();
#endregion
