namespace NeetCode.TwoPointer;

public class P344
{
    public static void Run()
    {
        char[] s = ['h', 'e', 'l', 'l', 'o'];

        ReverseString(s);
        Console.WriteLine(s.HwToString());
    }

    public static void ReverseString(char[] s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;
            l++;
            r--;
        }
    }
}
