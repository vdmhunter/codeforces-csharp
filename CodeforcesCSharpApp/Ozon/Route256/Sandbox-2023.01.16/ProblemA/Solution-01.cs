namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemA01;

public static class Program
{
    public static void Main(string[] args)
    {
        var tString = Console.ReadLine()!;
        var t = int.Parse(tString);
        
        for (var i = 0; i < t; i++)
        {
            var line = Console.ReadLine()!;
            var stringArr = line.Split(' ');
            var a = int.Parse(stringArr[0]);
            var b = int.Parse(stringArr[1]);
            var sum = a + b;

            Console.WriteLine(sum);
        }
    }
}

