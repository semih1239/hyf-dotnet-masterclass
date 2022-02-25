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