namespace ArrayClamp;

public class ArrayClampFinder
{
    public static int CountClamps(int[] array)
    {
        int count = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                if (i < array.Length - 1)
                {
                    if (array[i] == array[i + 1])
                    {
                        continue;
                    }
                }

                count++;
            }
        }

        return count;
    }
}