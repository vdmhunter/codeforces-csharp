namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemE01;

public static class Solution01
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine()!);
            var dic = new Dictionary<int, int[]>();
            var arr = new int[n];

            for (var j = 0; j < n; j++)
            {
                var eab = Console.ReadLine()!.Split(' ').Select(item => Convert.ToInt32(item)).ToArray();
                dic[eab[0]] = new[] { eab[1], eab[2] };
            }

            var first = dic.First();
            arr[0] = first.Value[0];
            arr[1] = first.Key;
            arr[2] = first.Value[1];
            dic.Remove(first.Key);
            var k = 2;

            while (dic.Count > 2)
            {
                arr[k + 1] = dic[arr[k]][0] == arr[k - 1] ? dic[arr[k]][1] : dic[arr[k]][0];
                dic.Remove(arr[k]);
                k++;
            }

            for (var j = 0; j < n / 2; j++)
            {
                var idx = ((j + n / 2) % n + n) % n;
                var str = $"{arr[j]} {arr[idx]}";

                Console.WriteLine(str);
            }
        }
    }
}
