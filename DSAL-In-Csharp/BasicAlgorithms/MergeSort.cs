using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL.BasicAlgorithms;

public class MergeSort
{
    // [1, 1, 8, 10, 4, 4, 5]
    public static int[] Sort(int[] array)
    {
        // stop recursion
        if (array.Length < 2)
            return array;
        //1-divid array into two arrays
        var middle = array.Length / 2;
        var left = new int[middle];
        for (int i = 0; i < middle; i++)
            left[i] = array[i];

        var right = new int[array.Length - middle];
        for (int i = middle; i < array.Length; i++)
            right[i - middle] = array[i];
        //2-sort each half
        Sort(left);
        Sort(right);
        //3-merge result
        Merge(left, right, array);
        return array;
    }

    static void Merge(int[] left, int[] right, int[] result)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                result[k++] = left[i++];
            else
                result[k++] = right[j++];
        }
        while (i < left.Length)
            result[k++] = left[i++];

        while (j < right.Length)
            result[k++] = right[j++];
    }
}
