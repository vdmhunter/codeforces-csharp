namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemD01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);
        
        for (var i = 0; i < t; i++)
        {
            Console.ReadLine();

            var nm = Console.ReadLine()!.Split(' ');
            var n = int.Parse(nm[0]);
            var m = int.Parse(nm[1]);

            var table = new Dictionary<int, List<int>>(n);

            for (var j = 0; j < n; j++)
                table.Add(j, Console.ReadLine()!.Split(' ').Select(int.Parse).ToList());

            var _ = int.Parse(Console.ReadLine()!);
            var c = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            table = c.Aggregate(table, (current, column) => current.OrderBy(r => r, new TableComparer(column - 1))
                .ToDictionary(pair => pair.Key, pair => pair.Value));

            foreach (var row in table.Values)
                Console.WriteLine(string.Join(" ", row));
            
            Console.WriteLine();
        }
    }
    
    private class TableComparer : IComparer<KeyValuePair<int, List<int>>>
    {
        private readonly int _column;

        public TableComparer(int column)
        {
            _column = column;
        }

        public int Compare(KeyValuePair<int, List<int>> x, KeyValuePair<int, List<int>> y)
        {
            return x.Value[_column].CompareTo(y.Value[_column]);
        }
    }
}
