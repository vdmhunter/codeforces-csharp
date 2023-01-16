namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20220817.ProblemG01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var nm = Console.ReadLine()!.Split(' ');
            var n = Convert.ToInt32(nm[0]);
            var m = Convert.ToInt32(nm[1]);

            var colCount = m % 2 == 0 ? m / 2 : m / 2 + 1;

            var map = new char?[n, colCount];
            var colors = new HashSet<char>();

            for (var r = 0; r < n; r++)
            {
                var rowColors = Console.ReadLine()!.Split('.', StringSplitOptions.RemoveEmptyEntries);
                
                for (var c = 0; c < colCount; c++)
                {
                    var color = m % 2 != 0 && r % 2 != 0 && c == colCount - 1
                        ? (char?)null
                        : rowColors[c][0];
                    
                    if(color.HasValue)
                        colors.Add(color.Value);
                    
                    map[r, c] = color;
                }
            }
            
            var groupCount = 0;
        
            for (var r = map.GetLength(0) - 1; r >= 0; r--)
                for (var c = map.GetLength(1) - 1; c >= 0; c--)
                    if (map[r, c].HasValue && map[r, c] != '0')
                    {
                        DfsFill(map, r, c, map[r, c]);
                        groupCount++;
                    }

            Console.WriteLine(groupCount == colors.Count ? "YES" : "NO");
        }
    }
    
    private static void DfsFill(char?[,] map, int r, int c, char? color)
    {
        if (r < 0 || c < 0 || r >= map.GetLength(0) || c >= map.GetLength(1) || map[r, c] != color)
            return;
        
        map[r, c] = '0';
            
        DfsFill(map, r, c - 1, color);
        DfsFill(map, r - 1, c, color);
        DfsFill(map, r, c + 1, color);
        DfsFill(map, r + 1, c, color);

        if (r % 2 != 0)
        {
            DfsFill(map, r - 1, c + 1, color);
            DfsFill(map, r + 1, c + 1, color);
        }
        else
        {
            DfsFill(map, r - 1, c - 1, color);
            DfsFill(map, r + 1, c - 1, color);
        }
    }
}
