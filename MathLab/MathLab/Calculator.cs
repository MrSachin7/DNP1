namespace MathLab;

public class Calculator
{
    public static int Add(short x, short y)
    {
        return x + y;
    }

    public static int Add(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        return sum;
    }

    public static int DisplayMax(int x, int y)
    {
        int max = x;
        if (y>max)
        {
            max = y;
        }
        return max;
    }
}