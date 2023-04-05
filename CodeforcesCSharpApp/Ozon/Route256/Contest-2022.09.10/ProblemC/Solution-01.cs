namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemC01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var _ = int.Parse(Console.ReadLine()!);

            var requests = Console.ReadLine()!.Split(' ').Select(a => Convert.ToInt32(a));

            int result = 0, current = 0, countClient2 = 0, client1 = 0, client2 = 0;
            
            foreach (var request in requests)
            {
                current = request == client1 || request == client2 ? current + 1 : countClient2 + 1;
                countClient2 = request == client2 ? countClient2 + 1 : 1;
                
                if (client2 != request)
                {
                    client1 = client2;
                    client2 = request;
                }

                result = Math.Max(result, current);
            }

            Console.WriteLine(result);
        }
    }
}
