public class CSharpEx2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a String:");
        string inputString = Console.ReadLine();
        Console.WriteLine("Enter a word to search:");
        string wordToSearch = Console.ReadLine();
        
        int count = 0;
        int startIndex = 0;
    
        while ((startIndex = inputString.IndexOf(wordToSearch, startIndex)) != -1)
        {
            count++;
            startIndex += wordToSearch.Length;
        }
        
        Console.WriteLine($"Word found {count} times in the string");
    } 
}