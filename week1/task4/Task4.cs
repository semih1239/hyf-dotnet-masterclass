int n = 6;
int nthNumber = Fibonacci(n);
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

int Fibonacci(int number)
{
    int[] fibonacciArray = new int[number + 1];
    for (int i = 0; i <= number; i++)
    {
        if (i == 0 || i == 1)
        {
            fibonacciArray[i] = i;
        }
        else
        {
            fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
        }
    }
    return fibonacciArray[number];
}