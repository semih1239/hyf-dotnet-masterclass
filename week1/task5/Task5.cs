int[] splitNumbers = new[] { 1, 5, 5, 5, 0, 4, 6, 7 };

if ((splitNumbers.Length) % 2 == 1)
{
    Console.WriteLine("Total Array items should be even");
}
else
{
    int[,] splitArray = Split(splitNumbers);
    int[] result = AddArray(splitArray);
    WriteResult(result);
}


int[,] Split(int[] numbers)
{
    int[,] array = new int[2, numbers.Length / 2];
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
    return array;
}

int[] AddArray(int[,] arr)
{
    int[] array = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        array[i] = arr[0, i] + arr[1, i];
    }
    return array;
}

void WriteResult(int[] result)
{
    Console.WriteLine(String.Join(",", result));
}