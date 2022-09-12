using System.Text;

namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemC01;

public static class Program
{
    public static void Main(string[] args)
    {
        var result = new StringBuilder();
        
        var t = int.Parse(Console.ReadLine()!);
        
        for (var i = 0; i < t; i++)
        {
            var line = Console.ReadLine()!;

            while (line.Length > 0)
            {
                switch (line[..2])
                {
                    case "00":
                        result.Append('a');
                        line = line[2..];
                        break;
                    case "11":
                        result.Append('d');
                        line = line[2..];
                        break;
                    default:
                        switch (line[..3])
                        {
                            case "100":
                                result.Append('b');
                                line = line[3..];
                                break;
                            case "101":
                                result.Append('c');
                                line = line[3..];
                                break; 
                        }
                        break;
                } 
            }
            
            Console.WriteLine(result.ToString());
            
            result.Clear();
        }
    }
}
