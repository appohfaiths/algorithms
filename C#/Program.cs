using Recursive;
using Sum;
using Fibonacci;
using BinarySearch;
using SortingAlgorithms;

// Sum
// int sum = SUMOFNUMBERS.ArraySum(new List<int> { 1, 2, 3, 4, 5 });
// Console.WriteLine("sum is " + sum);

// Rod cutting
/*
int rod = CUT_ROD_RECURSIVE.CUT_ROD(new List<int> { -1000, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 }, 4);
Console.WriteLine("rod is " + rod);
*/

// Fibonacci Sequence
/*
Console.WriteLine(Fibonacci_Recursive.Fibonacci(5));

int n = 8;
List<int> fibonacciSequence = Fibonacci_Recursive.GenerateFibonacciSequence(n);
Console.WriteLine("Fibonacci Sequence up to " + n + ":");
foreach (int number in fibonacciSequence)
{
    Console.Write(number + " ");
}
*/

// Binary Search
/*
var array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int targetValue = 7;

int result = Binary_Search.BinarySearch(array, targetValue);

if (result != 1)
    Console.WriteLine($" Target {targetValue} was found at index {result}");
else
{
    Console.WriteLine($"Target  {targetValue} was not found in the array");
}
*/

var unsortedArray = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
var sortedArray = Quick_Sort.QuickSort(unsortedArray);
Console.WriteLine(sortedArray);