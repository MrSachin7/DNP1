namespace BiggestDifference;

public class BiggestDifferenceInAnArray
{
    public static int BigDiff(int[] array)
    {
        int minElement = array[0];
        int maxDiff = 0;
        for (int i = 1; i < array.Length; i++)
        {
            minElement = Math.Min(minElement, array[i]);
            maxDiff = Math.Max(maxDiff, array[i-1] - minElement);
        }

        return maxDiff;
    }
}