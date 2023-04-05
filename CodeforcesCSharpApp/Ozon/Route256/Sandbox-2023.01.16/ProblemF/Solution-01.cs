namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemF01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine()!);
            var flag = false;

            var timeSpans = new List<TimeSpan>();

            for (var j = 0; j < n; j++)
            {
                var line = Console.ReadLine()!;

                if (flag)
                    continue;
                
                if (!DateTime.TryParseExact(line.Split('-')[0], "HH:mm:ss", null,
                        System.Globalization.DateTimeStyles.None, out var t1))
                {
                    flag = true;
                    
                    continue;
                }
                
                if (!DateTime.TryParseExact(line.Split('-')[1], "HH:mm:ss", null,
                        System.Globalization.DateTimeStyles.None, out var t2))
                {
                    flag = true;
                                    
                    continue;
                }

                if (t1 > t2)
                {
                    flag = true;
                    
                    continue;
                }

                timeSpans.Add(new TimeSpan
                {
                    Begin = t1,
                    End = t2
                });
            }

            if (flag || IsOverlapped(timeSpans))
            {
                Console.WriteLine("NO");

                continue;
            }

            Console.WriteLine("YES");
        }
    }

    private static bool IsOverlapped(List<TimeSpan> timeSpans)
    {
        if(timeSpans == null || timeSpans.Count == 0)
            return false;
        
        timeSpans.Sort((x, y) => x.Begin.CompareTo(y.Begin));

        for (var i = 1; i < timeSpans.Count; i++)
        {
            var i1 = timeSpans[i - 1];
            var i2 = timeSpans[i];
            
            if(i1.End >= i2.Begin)
                return true;
        }

        return false;
    }

    private struct TimeSpan
    {
        public DateTime Begin;

        public DateTime End;
    }
}
