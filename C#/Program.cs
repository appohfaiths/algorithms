using Recursive;
using Sum;
using Fibonacci;

// int sum = SUMOFNUMBERS.ArraySum(new List<int> { 1, 2, 3, 4, 5 });
// Console.WriteLine("sum is " + sum);

/*
int rod = CUT_ROD_RECURSIVE.CUT_ROD(new List<int> { -1000, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 }, 4);
Console.WriteLine("rod is " + rod);
*/

Console.WriteLine(Fibonacci_Recursive.Fibonacci(5));

int n = 8;
List<int> fibonacciSequence = Fibonacci_Recursive.GenerateFibonacciSequence(n);
Console.WriteLine("Fibonacci Sequence up to " + n + ":");
foreach (int number in fibonacciSequence)
{
    Console.Write(number + " ");
}