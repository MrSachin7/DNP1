namespace PrintingNumbers;

public class PrintNumbers
{
    public static void PrintEvenNumbersUpto(int x)
    {
        for (int i = 1; i < x; i++)
        {
            if (i % 2 ==0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void PrintNotEvenNumbersUpto(int x)
    {
        for (int i = 1; i < x; i++)
        {
            if (i % 2 !=0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void PrintNumbersDivisible(int dividend,int divider)
    {
        for (int i = 1; i < dividend; i++)
        {
            if (i % divider==0)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}