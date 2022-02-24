// See https://aka.ms/new-console-template for more information

using MathLab;

// Console.WriteLine(Calculator.Add(5, 7));
// int[] array = {1, 2, 3, 4, 5};
// Console.WriteLine(Calculator.Add(array));
    
Console.WriteLine("Enter number x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number y ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max number : "+ Calculator.DisplayMax(x,y));