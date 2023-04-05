namespace CodeforcesCSharpApp.Round0821.ProblemA;

public static class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var nk = Console.ReadLine()!.Split(' ');
            var k = Convert.ToInt32(nk[1]);

            var a = Console.ReadLine()!.Split(' ').Select(el => Convert.ToInt32(el));

            var dictionary = a.Select((el, idx) => new { Item = el, Index = idx + 1 })
                .GroupBy(el => el.Index % k)
                .ToDictionary(g => g.Key, g => g.Select(el => el.Item).OrderByDescending(el => el).ToList());

            var sum = dictionary.Keys
                .Where(key => dictionary[key].Count != 0)
                .Aggregate(0L, (current, key) => current + dictionary[key][0]);

            Console.WriteLine(sum);
        }
    }
}
