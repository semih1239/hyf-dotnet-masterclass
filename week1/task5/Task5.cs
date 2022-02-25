int[] splitNumbers = new[] { 1, 5, 5, 5, 0, 4, 6, 7 };
int[,] splitArray = new int[2, splitNumbers.Length / 2];
int[] result = new int[splitArray.Length / 2];

if ((splitNumbers.Length) % 2 == 1)
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