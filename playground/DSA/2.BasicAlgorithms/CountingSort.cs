namespace DSA.BasicAlgorithms;

public class CountingSort
{
    public static void Run() { }

    // [1, 1, 8, 10, 4, 4, 5]
    public static int[] Sort(int[] array)
    {
        // Find the maximum value in the array
        int max = array.Max();

        // Initialize an array to store counts of each element
        int[] counts = new int[max + 1];

        // Count occurrences of each element in the input array
        CountOccurrences(array, counts);

        // Reconstruct the sorted array based on counts
        ReconstructArray(array, counts);

        return array;
    }

    private static void CountOccurrences(int[] array, int[] counts)
    {
        foreach (int num in array)
        {
            counts[num]++;
        }
    }

    private static void ReconstructArray(int[] array, int[] counts)
    {
        int k = 0; // Index for the original array

        // Iterate over each element count
        for (int i = 0; i < counts.Length; i++)
        {
            // Add the current element i 'counts[i]' times to the original array
            for (int j = 0; j < counts[i]; j++)
            {
                array[k++] = i;
            }
        }
    }
}
