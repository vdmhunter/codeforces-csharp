namespace CodeforcesCSharpApp.Round0820.ProblemB;

public static class Solution01
{
    public static void Main(string[] args)
    {
        var q = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < q; i++)
        {
            var reversedWord = string.Empty;
            
            var n = int.Parse(Console.ReadLine()!);
            
            var code = Console.ReadLine()!;
            var reversedCode = new string(code.ToCharArray().Reverse().ToArray());

            for (var p = 0; p < n; p++)
            {
                var number = reversedCode[p] - '0';
                
                if (number != 0)
                {
                    reversedWord += (char)('a' + (number - 1));
                    continue;
                }
                
                var tmp = new string(reversedCode[p..(p + 3)][1..].ToCharArray().Reverse().ToArray());
                number = Convert.ToInt32(tmp);
                reversedWord += (char)('a' + (number - 1));
                p += 2;
            }
            
            var word = new string(reversedWord.ToCharArray().Reverse().ToArray());
            
            if(i < q - 1)
                Console.WriteLine(word);
            else
                Console.Write(word);
        }
    }
}
