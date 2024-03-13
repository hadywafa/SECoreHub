namespace DSAL;
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
}