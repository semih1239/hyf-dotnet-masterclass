int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] resultArray = GetResult(arr);
Console.WriteLine($"Sum of negative numbers: {resultArray[0]}. Multiplication of positive numbers: {resultArray[1]}");


int[] GetResult(int[] arr)
{
    int positiveNumber = 1;
    int negativeNumber = 0;

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
    return new[] { negativeNumber, positiveNumber };
}
