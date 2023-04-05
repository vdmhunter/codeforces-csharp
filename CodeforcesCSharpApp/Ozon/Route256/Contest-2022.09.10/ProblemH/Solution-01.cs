using System.Text;

namespace CodeforcesCSharpApp.Ozon.Route256.Contest_20220910.ProblemH01;

public static class Program
{
    private static readonly StringBuilder Trees = new();

    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine()!);

        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine()!);
            var nodes = new List<Node>(n);

            for (var r = 0; r < n; r++)
            {
                var line = Console.ReadLine()!;
                var firstSpaceIdx = line.IndexOf(' ');
                var secondSpaceIdx = line.IndexOf(' ', firstSpaceIdx + 1);

                var id = Convert.ToInt32(line[..firstSpaceIdx]);
                var p = Convert.ToInt32(line[(firstSpaceIdx + 1)..secondSpaceIdx]);
                var text = line[(secondSpaceIdx + 1)..];

                nodes.Add(new Node
                {
                    Id = id,
                    P = p,
                    Comment = text
                });
            }

            foreach (var node in nodes)
            {
                var parent = nodes.FirstOrDefault(nds => nds.Id == node.P);
                parent?.Children.Add(node);
            }

            var roots = nodes.Where(p => p.P == -1).OrderBy(p => p.Id).ToList();

            for (var j = 0; j < roots.Count; j++)
            {
                PrintTree(roots[j], "", true);
                if (j != roots.Count - 1)
                    Trees.Append('\n');
            }

            Trees.Append('\n');
        }

        Console.Write(Trees.Replace("\n", Environment.NewLine));

        Trees.Clear();
    }

    private static void PrintTree(Node tree, string indent, bool last)
    {
        if (tree.P != -1)
            Trees.Append(indent + (tree.P == -1 ? "" : "|") + "\n");

        Trees.Append(indent + (tree.P == -1 ? "" : "|--") + tree.Comment + "\n");
        indent += last ? tree.P == -1 ? "" : "   " : "|  ";

        var i = 0;

        foreach (var child in tree.Children.OrderBy(n => n.Id))
        {
            PrintTree(child, indent, i == tree.Children.Count - 1);
            i++;
        }
    }
}

public class Node
{
    public int Id;

    public int P;

    public readonly List<Node> Children;

    public string? Comment;

    public Node()
    {
        Children = new List<Node>();
    }
}