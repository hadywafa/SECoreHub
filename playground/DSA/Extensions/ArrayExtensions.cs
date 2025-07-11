namespace DSA.Extensions;

public static class ArrayExtensions
{
    public static void PrintValues<T>(this T[] array)
    {
        if (array == null)
        {
            Console.WriteLine("null");
            return;
        }

        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    public static void Swap<T>(this T[] array, int index1, int index2)
    {
        var tempIndex1Value = array[index1];
        array[index1] = array[index2];
        array[index2] = tempIndex1Value;
    }
}
