namespace CodeforcesCSharpApp.EducationalRound0136.ProblemB;

public class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var x = 0; x < t; x++)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var stringArr = Console.ReadLine()!.Split(' ');
            var a = stringArr.Select(int.Parse).ToArray();

            var result = new int[n];
            result[0] = a[0];

            for (var y = 1; y < n; y++)
            {
                if (a[y] <= result[y - 1] && a[y] != 0)
                {
                    result = new[] { -1 };
                    
                    break;
                }
                
                result[y] = a[y] + result[y - 1];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
