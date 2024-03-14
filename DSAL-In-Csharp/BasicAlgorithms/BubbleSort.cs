using DSAL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL.BasicAlgorithms;

public class BubbleSort
{
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
