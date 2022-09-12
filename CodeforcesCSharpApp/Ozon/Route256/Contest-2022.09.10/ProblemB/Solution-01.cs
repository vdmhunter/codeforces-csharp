namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemB01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);
        
        for (var i = 0; i < t; i++)
        {
            var line = Console.ReadLine()!.Split(' ');
            var day = Convert.ToInt32(line[0]);
            var month = Convert.ToInt32(line[1]);
            var year = Convert.ToInt32(line[2]);

            try
            {
                var _ = new DateTime(year, month, day);
            }
            catch (Exception)
            {
                Console.WriteLine("NO");
                continue;
            }

            Console.WriteLine("YES");
        }
    }
}
