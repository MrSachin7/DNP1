// See https://aka.ms/new-console-template for more information

using LargestNumberInArray;

int[] array = new int[] {10, 6, 4, 4, 7, 7, 2, 20};
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(CalculatorLargeNumberInAnArray.KthLargestNumber(array, 0));
}