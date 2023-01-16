namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20220817.ProblemI01;

public static class Program
{
    private static readonly List<string> Wordbook = new();

    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < n; i++)
        {
            var word = Console.ReadLine()!;
            Wordbook.Add(ReverseString(word));
        }

        var defaultWord = ReverseString(Wordbook[0]); 
        
        Wordbook.Sort();
        
        var q = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < q; i++)
        {
            var query = Console.ReadLine()!;
            var rhyme = Rhyme(ReverseString(query));
            var result = rhyme == string.Empty ? defaultWord : rhyme;
            
            Console.WriteLine(result);
        }
    }

    private static string Rhyme(string searchWord)
    {
        var result = string.Empty;
        var prefix = string.Empty;
        
        var pos = Wordbook.BinarySearch(searchWord);

        if (pos >= 0)
            Wordbook.RemoveAt(pos);

        foreach (var c in searchWord)
        {
            prefix += c;
            
            var start = Wordbook.BinarySearch(prefix);
            
            if (start >= 0)
            {
                result = Wordbook[start];

                continue;
            }
            
            start = ~start;
            
            if(start >= Wordbook.Count)
                break;

            if (Wordbook[start].Length >= prefix.Length && Wordbook[start][..prefix.Length].Equals(prefix))
                result = Wordbook[start];
            else
                break;
        }
        
        if (pos >= 0)
            Wordbook.Insert(pos, searchWord);

        return ReverseString(result);
    }

    private static string ReverseString(string str)
    {
        var charArray = str.ToCharArray();
        Array.Reverse(charArray);
        var reversePart = new string(charArray);
        
        return reversePart;
    }
}