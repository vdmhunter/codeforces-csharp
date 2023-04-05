using System.Text;

namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemD01;

public static class Program
{
    public static void Main(string[] args)
    {
        var result = new StringBuilder();

        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var nm = Console.ReadLine()!.Split(' ');
            var n = Convert.ToInt32(nm[0]);
            var m = Convert.ToInt32(nm[1]);

            var field = new char[n, m];
            var visited = new List<(int row, int column)>();
            (int row, int column) current = (-1, -1);

            for (var r = 0; r < n; r++)
            {
                var line = Console.ReadLine()!;

                for (var c = 0; c < m; c++) field[r, c] = line[c];
            }

            for (var r = 0; r < n; r++)
            for (var c = 0; c < m; c++)
                if (CanBeFirst((r, c)))
                    current = (r, c);

            visited.Add(current);

            while (true)
            {
                if (current.row > 0
                    && !visited.Contains((current.row - 1, current.column))
                    && field[current.row - 1, current.column] == '*')
                {
                    current = (current.row - 1, current.column);
                    visited.Add(current);
                    result.Append('U');

                    continue;
                }

                if (current.column < m - 1
                    && !visited.Contains((current.row, current.column + 1))
                    && field[current.row, current.column + 1] == '*')
                {
                    current = (current.row, current.column + 1);
                    visited.Add(current);
                    result.Append('R');

                    continue;
                }

                if (current.row < n - 1
                    && !visited.Contains((current.row + 1, current.column))
                    && field[current.row + 1, current.column] == '*')
                {
                    current = (current.row + 1, current.column);
                    visited.Add(current);
                    result.Append('D');

                    continue;
                }

                if (current.column > 0
                    && !visited.Contains((current.row, current.column - 1))
                    && field[current.row, current.column - 1] == '*')
                {
                    current = (current.row, current.column - 1);
                    visited.Add(current);
                    result.Append('L');

                    continue;
                }

                break;
            }

            Console.WriteLine(result.ToString());
            result.Clear();

            bool CanBeFirst((int row, int column) cell)
            {
                var count = 0;

                if (field[cell.row, cell.column] == '*')
                {
                    if (cell.row > 0 && field[cell.row - 1, cell.column] == '*') count++;
                    if (cell.column < m - 1 && field[cell.row, cell.column + 1] == '*') count++;
                    if (cell.row < n - 1 && field[cell.row + 1, cell.column] == '*') count++;
                    if (cell.column > 0 && field[cell.row, cell.column - 1] == '*') count++;
                }

                return count == 1;
            }
        }
    }
}