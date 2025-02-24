internal class Program
{
    static void Main(string[] args)
    {
        string reversedString = ReverseWords(" string s ");
        Console.WriteLine(reversedString);
    }
    public static string ReverseWords(string s)
    {   
        List<string> originalWord = s.TrimStart().TrimEnd().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> reversedWords = new List<string>();

        for (int i = originalWord.Count -1; i >= 0; i--)
        {
            reversedWords.Add(originalWord[i]);
        }
        return string.Join(" ", reversedWords);
    }
}
