namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemG01;

public static class Program
{
    public static void Main(string[] args)
    {
        var nm = Console.ReadLine()!.Split(' ');
        var n = int.Parse(nm[0]);
        var m = int.Parse(nm[1]);
        
        var adj = new Dictionary<int, List<int>>();
        
        for (var i = 0; i < n; i++)
            adj[i] = new List<int>();

        for (var i = 0; i < m; i++)
        {
            var uv = Console.ReadLine()!.Split(' ');
            var u = int.Parse(uv[0]);
            var v = int.Parse(uv[1]);

            adj[u - 1].Add(v - 1);
            adj[v - 1].Add(u - 1);
        }
        
        for (var i = 0; i < n; i++)
            Console.WriteLine(string.Join(" ", Bfs(adj, i)));
    }

    private static List<int> Bfs(Dictionary<int, List<int>> adj, int s)
    {
        var v2 = new Dictionary<int, int>();
        
        var lengths = new Dictionary<int, int>();
        var visited = new Dictionary<int, bool>();

        var q = new Queue<int>();

        visited[s] = true;
        q.Enqueue(s);

        while (q.Count > 0)
        {
            var u = q.Dequeue();

            foreach (var v in adj[u].Where(v => !visited.GetValueOrDefault(v)))
            {
                if (lengths.ContainsKey(v))
                    lengths[v] = lengths.GetValueOrDefault(u) + 1;
                else
                    lengths.Add(v, lengths.GetValueOrDefault(u) + 1);
                    
                if (lengths[v] == 2)
                {
                    if(v2.ContainsKey(v))
                        v2[v]++;
                    else
                        v2.Add(v, 1);
                }
                else
                {
                    if(visited.ContainsKey(v))
                        visited[v] = true;
                    else
                        visited.Add(v, true);

                    q.Enqueue(v);
                }
            }
        }
        
        if (v2.Count == 0)
            return new List<int> { 0 };

        var max = v2.Select(p => v2[p.Key]).Prepend(-1).Max();
        var result = (from p in v2 where v2[p.Key] == max select p.Key + 1).ToList();

        result.Sort();

        return result;
    }
}
