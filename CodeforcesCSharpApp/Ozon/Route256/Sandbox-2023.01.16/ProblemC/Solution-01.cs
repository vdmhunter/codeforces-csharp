namespace CodeforcesCSharpApp.Ozon.Route256.Sandbox_20230116.ProblemC01;

public static class Program
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine()!);
            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var skills = new Dictionary<int, int>();
            var positions = new List<int>();

            for (var j = 0; j < n; j++)
            {
                skills.Add(j, a[j]);
                positions.Add(j);
            }

            foreach (var position in positions)
            {
                if (!skills.ContainsKey(position))
                    continue;

                var skill = skills[position];

                skills.Remove(position);
                var closestPosition = skills.MinBy(s => s, new SkillComparer(skill)).Key;
                skills.Remove(closestPosition);

                Console.WriteLine($"{position + 1} {closestPosition + 1}");
            }

            if (i != t - 1)
                Console.WriteLine();
        }
    }

    private class SkillComparer : IComparer<KeyValuePair<int, int>>
    {
        private readonly int _skill;

        public SkillComparer(int skill)
        {
            _skill = skill;
        }

        public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
        {
            return Math.Abs(x.Value - _skill) != Math.Abs(y.Value - _skill)
                ? Math.Abs(x.Value - _skill).CompareTo(Math.Abs(y.Value - _skill))
                : x.Key.CompareTo(y.Key);
        }
    }
}
