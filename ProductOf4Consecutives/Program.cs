// See https://aka.ms/new-console-template for more information

using ProductOf4Consecutives;

ProductFinder productFinder = new ProductFinder();
Console.WriteLine(productFinder.TheNumber);
Console.WriteLine(productFinder.BiggestProductOfFourConsecutive());
productFinder.PrintThoseFourNumbersAndTheirIndexPlease();
Console.WriteLine(productFinder.FindTheBiggestProductOfXConsecutiveNumbers(6));
productFinder.PrintThoseXNumbersAndTheirIndexPlease(6);