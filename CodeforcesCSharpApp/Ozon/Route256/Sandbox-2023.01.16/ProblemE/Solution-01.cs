namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemE01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine()!);
            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var previousTaskId = 0;
            var tasks = new HashSet<int>();
            var flag = false;

            for (var j = 0; j < n; j++)
            {
                var taskId = a[j];

                if (previousTaskId == 0)
                    previousTaskId = taskId;

                if (!tasks.Contains(taskId))
                {
                    tasks.Add(taskId);
                    previousTaskId = taskId;
                }
                else if (previousTaskId != taskId)
                {
                    flag = true;
                    Console.WriteLine("NO");

                    break;
                }
            }

            if (!flag)
                Console.WriteLine("YES");
        }
    }
}
