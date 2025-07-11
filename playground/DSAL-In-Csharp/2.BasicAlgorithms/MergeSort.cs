namespace DSAL.BasicAlgorithms;

public class MergeSort
{
    public static void Run() { }

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
        int i = 0; // Index for the left array
        int j = 0; // Index for the right array
        int k = 0; // Index for the merged result array

        // Compare elements from left and right arrays
        // and merge them into the result array in sorted order
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                result[k++] = left[i++];
            else
                result[k++] = right[j++];
        }

        // Add any remaining elements from the left array to the result array
        while (i < left.Length)
            result[k++] = left[i++];

        // Add any remaining elements from the right array to the result array
        while (j < right.Length)
            result[k++] = right[j++];
    }
}
