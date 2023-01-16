namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemB01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);
        
        for (var i = 0; i < t; i++)
        {
            var _ = int.Parse(Console.ReadLine()!);
            var p = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var goods = new Dictionary<int, int>();

            foreach (var goodPrice in p)
            {
                if (goods.ContainsKey(goodPrice))
                    goods[goodPrice]++;
                else
                    goods.Add(goodPrice, 1);
            }

            var totalPrice = 0L;

            foreach (var (price, count) in goods)
            {
                var goodCountForPay = count / 3 * 2 + count % 3;
                totalPrice += price * goodCountForPay;
            }
                
            Console.WriteLine(totalPrice);
        }
    }
}
