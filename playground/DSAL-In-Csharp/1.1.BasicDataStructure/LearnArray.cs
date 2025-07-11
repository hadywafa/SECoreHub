namespace DSAL.Part1;

public class LearnArray
{
    public LearnArray()
    {
        int[] array1 = new int[3];
        int[] array2 = new int[] { 1, 2, 4 };
        int[] array3 = [1, 2, 4];
        string result = "[" + string.Join(", ", array3.Select(n => n.ToString())) + "]";
        System.Console.WriteLine(string.Join(", ", result));
        Array.Copy(array3, array2, array3.Length);
        Array.Copy(array3, 2, array3, 2 + 1, array3.Length - 2);
    }
}

//-----------------------------------------------

public class CustomArray
{
}
