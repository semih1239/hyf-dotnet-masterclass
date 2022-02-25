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