using DSAL.Extensions;

namespace DSAL.BasicAlgorithms;

public class BubbleSort
{
    public static void Run()
    {
        BubbleSort.SortV2([1, 1, 8, 10, 4, 4, 5]).PrintValues();
        SelectionSort.SortV1([1, 1, 8, 10, 4, 4, 5]).PrintValues();
        InsertionSort.SortV1([1, 1, 8, 10, 4, 4, 5]).PrintValues();
        MergeSort.Sort([1, 1, 8, 10, 4, 4, 5]).PrintValues();
        CountingSort.Sort([1, 1, 8, 10, 4, 4, 5]).PrintValues(); 
    }

    public static int[] SortV1(int[] array)
    {
        // [1, 1, 8, 10, 4, 4, 5]
        foreach (var item in array)
            for (int i = 1; i < array.Length; i++)
                if (array[i] < array[i - 1])
                    array.Swap(i, i - 1);

        return array;
    }

    public static int[] SortV2(int[] array)
    {
        // [1, 1, 8, 10, 4, 4, 5]
        for (int i = 0; i < array.Length; i++)
            for (int j = 1; j < array.Length - i; j++)
                if (array[j] < array[j - 1])
                    array.Swap(j, j - 1);

        return array;
    }
}
