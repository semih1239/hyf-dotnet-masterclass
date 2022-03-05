string wordToReverse = "Hello World";
string newInput = ReverseString(wordToReverse);

string ReverseString(string word)
{
    char[] array = word.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}

Console.WriteLine(newInput);