namespace CodeforcesCSharpApp.Round0863.ProblemA01;

using System;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var nd = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var n = nd[0];
            var d = nd[1];
            var num = Console.ReadLine()!;

            int j;

            for (j = 0; j < n; j++)
            {
                if (num[j] - '0' >= d)
                    continue;

                Console.WriteLine(num[..j] + (char)('0' + d) + num[j..]);

                break;
            }

            if (j == n)
                Console.WriteLine(num + (char)('0' + d));
        }
    }
}
