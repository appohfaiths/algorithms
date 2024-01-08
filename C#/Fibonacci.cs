namespace Fibonacci;

public class Fibonacci_Recursive
{
    public static List<int> GenerateFibonacciSequence(int num)
    {
        var sequence = new List<int> { };

        for (int i = 1; i <= num; i++)
        {
            sequence.Add(Fibonacci(i));
        }
        return sequence;
    }
    public static int Fibonacci(int n)
    {
        if (n == 1)
            return 0;
        if (n == 2)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}