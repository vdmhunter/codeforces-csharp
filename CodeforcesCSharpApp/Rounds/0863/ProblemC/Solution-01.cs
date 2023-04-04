namespace CodeforcesCSharpApp.Round0863.ProblemC01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var k = 0; k < t; k++)
        {
            int n = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] a = new int[n];
            a[n - 1] = b[n - 2]; // последний элемент a равен предпоследнему элементу b

            for (int j = n - 2; j >= 1; j--) {
                a[j] = Math.Max(b[j - 1], a[j + 1]); // элемент a равен максимуму из двух значений
            }

            a[0] = b[0]; // первый элемент a равен первому элементу b

            Console.WriteLine(string.Join(" ", a));

        }
    }
}
