namespace LargestNumberInArray;

public class CalculatorLargeNumberInAnArray {
    public static int KthLargestNumber(int[] array, int k) {
        if (k > array.Length) {
            throw new Exception("K is bigger than the length of the provided array");
        }
        if (k<=0) {
            throw new Exception("K must be bigger than zero");
        }

        //
        List<int> originalList = new List<int>();
        originalList = array.ToList();

        List<int> tempList = originalList.Take(k).ToList();
        for (int i = k ; i < originalList.Count; i++) {

           // Console.WriteLine($"Checking...{originalList[i]}");
          //  tempList.ForEach(Console.WriteLine);

            int m = SmallestNumber(tempList);
            if (originalList[i] > m) {
                tempList.Remove(m);
                tempList.Add(originalList[i]);
            }
        }
        return SmallestNumber(tempList);
    }

    private static int SmallestNumber(List<int> list) {
        int min = list[0];
        foreach (var i in list) {
            if (i < min) {
                min = i;
            }
        }

        return min;
    }
}