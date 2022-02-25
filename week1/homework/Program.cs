// 1. String manipulation

string wordToReverse = "Hello World";
string newInput = ReverseString(wordToReverse);

string ReverseString(string word)
{
    char[] array = word.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}

Console.WriteLine(newInput);

// 2. String/Math

string input = "Intellectualization";

int GetVovelCount(string word)
{
    word.ToLower();
    int count = 0;
    foreach (char c in word)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine($"Number of vowels: {GetVovelCount(input)}");

// 3. Math/Array

int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] resultArray = new int[2];
GetResult(arr);
void GetResult(Array arr)
{
    int positiveNumber = 1;
    int negativeNumber = new int();

    foreach (int number in arr)
    {
        if (number > 0)
        {
            positiveNumber *= number;
        }
        else
        {
            negativeNumber += number;
        }
    }

    resultArray[0] = negativeNumber;
    resultArray[1] = positiveNumber;
}
Console.WriteLine($"Sum of negative numbers: {resultArray[0]}. Multiplication of positive numbers: {resultArray[1]}");

// 4. Classical task

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

// 5. Arrays

int[] splitNumbers = new[] { 1, 5, 5, 5, 0, 4, 6, 7 };
int[,] splitArray = new int[2, splitNumbers.Length / 2];
int[] result = new int[splitArray.Length / 2];

if ((splitNumbers.Length / 2) % 2 == 1)
{
    Console.WriteLine("Total Array items should be even");
}
else
{
    splitArray = new int[2, splitNumbers.Length / 2];
    result = new int[splitArray.Length / 2];
    Split(splitNumbers);
    AddArray(splitArray);
    WriteResult(result);
}

void Split(int[] numbers)
{
    int[,] array = new int[2, splitNumbers.Length / 2];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length / 2)
        {
            array[0, i] = numbers[i];
        }
        else
        {
            array[1, i - numbers.Length / 2] = numbers[i];
        }
    }
    splitArray = array;
}

void AddArray(int[,] arr)
{
    int[] array = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        array[i] = arr[0, i] + arr[1, i];
    }
    result = array;
}

void WriteResult(int[] result)
{
    Console.WriteLine(String.Join(",", result));
}




