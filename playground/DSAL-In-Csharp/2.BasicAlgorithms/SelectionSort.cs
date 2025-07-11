using DSAL.Extensions;

namespace DSAL.BasicAlgorithms;

public class SelectionSort
{
    public static void Run() { }

    public static int[] SortV1(int[] array)
    {
        // [1, 1, 8, 10, 4, 4, 5]
        for (int i = 0; i < array.Length - 1; i++)
        {
            // Find the index of the minimum element in the unsorted part of the array
            int minIndex = GetNexMinIndex(i, array);
            // Swap if the current index is not the min value
            if (minIndex != i)
                array.Swap(minIndex, i);
        }
        return array;
    }

    private static int GetNexMinIndex(int i, int[] array)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
                minIndex = j;
        }
        return minIndex;
    }
}
