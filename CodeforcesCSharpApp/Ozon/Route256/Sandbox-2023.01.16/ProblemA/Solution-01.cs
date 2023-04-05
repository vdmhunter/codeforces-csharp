namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemA01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);
        
        for (var i = 0; i < t; i++)
        {
            var ab = Console.ReadLine()!.Split(' ');
            var a = int.Parse(ab[0]);
            var b = int.Parse(ab[1]);
            var sum = a + b;

            Console.WriteLine(sum);
        }
    }
}

