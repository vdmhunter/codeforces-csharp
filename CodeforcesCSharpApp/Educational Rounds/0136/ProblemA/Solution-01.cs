namespace CodeforcesCSharpApp.EducationalRound0136.ProblemA;

public class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var x = 0; x < t; x++)
        {
            var nm = Console.ReadLine()!.Split(' ');
            var n = nm[0];
            var m = nm[1];
            
            if (n == "1" || m == "1")
                Console.WriteLine("1 1");
            else
                Console.WriteLine("2 2");
        }
    }
}
