namespace CodeforcesCSharpApp.Round0836.ProblemA;

public class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var s = Console.ReadLine()!;
            var ca = s.ToCharArray();
            Array.Reverse(ca);
            Console.WriteLine(s + new string(ca));
        }
    }
}
