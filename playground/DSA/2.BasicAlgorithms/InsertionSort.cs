namespace DSA.BasicAlgorithms;

public class InsertionSort
{
    public static void Run() { }

    public static int[] SortV1(int[] array)
    {
        // [1, 1, 8, 10, 4, 4, 5]
        for (int i = 1; i < array.Length; i++)
        {
            //tempValue
            var tempCurrentValue = array[i];
            var previousIndex = i - 1;
            while (previousIndex >= 0 && array[previousIndex] > tempCurrentValue)
            {
                //shifting by copy values
                array[previousIndex + 1] = array[previousIndex];
                previousIndex--;
            }
            array[previousIndex + 1] = tempCurrentValue;
        }
        return array;
    }
}
