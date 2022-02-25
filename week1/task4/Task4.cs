int n = 6;
int nthNumber = Fibonacci(n);
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

int Fibonacci(int n)
{
    List<int> fibonacciArray = new List<int>();
    for (int i = 0; i <= n; i++)
    {
        if (i == 0 || i == 1)
        {
            fibonacciArray.Add(i);
        }
        else
        {
            fibonacciArray.Add(fibonacciArray.Last() + fibonacciArray[i - 2]);
        }
    }
    return fibonacciArray.Last();
}