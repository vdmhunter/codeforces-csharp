namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20220817.ProblemA01;

public static class Program
{
    public static void Main(string[] args)
    {
        var testCaseCountString = Console.ReadLine()!;
        var testCaseCount = int.Parse(testCaseCountString);
        
        for (var i = 0; i < testCaseCount; i++)
        {
            var line = Console.ReadLine()!;
            var stringArr = line.Split(' ');
            var intArr = stringArr.Select(int.Parse).ToArray();

            Console.WriteLine(intArr.Sum());
        }
    }
}
