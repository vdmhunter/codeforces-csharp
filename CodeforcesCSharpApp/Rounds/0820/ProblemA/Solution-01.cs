namespace CodeforcesCSharpApp.Round0820.ProblemA;

public class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var abc = Console.ReadLine()!.Split(' ');
            var a = Convert.ToInt32(abc[0]);
            var b = Convert.ToInt32(abc[1]);
            var c = Convert.ToInt32(abc[2]);

            var time2 = c > b ? c - b + c : b;

            if (time2 > a)
                Console.WriteLine("1");
            if (time2 < a)
                Console.WriteLine("2");
            if (time2 == a)
                Console.WriteLine("3");
        }
    }
}
