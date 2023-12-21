namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("asfds");
        list.Add("bsaddf");
        list.Add("ad");
        list.Add("cdsfadsda");
        list.AddRange(new List<string> { "dsfadd", "dde", "ddddf" });

        Func<string, bool> check = Program.IsA;
        IEnumerable<string> ahs = EnumerableUtils.Fulfills(list, IsA);
        IEnumerable<string> sorted = EnumerableUtils.SortValues(ahs);
        IEnumerable<int> values = EnumerableUtils.Project<string, int>(sorted);

        values = list.Fulfills(IsA).SortValues().Project<string, int>();

        values = list.Where(x => x.Length <20).OrderBy(x => x.Length).Select(s=>s.Length);

        string[] strings = { "2" };
        Stack<string> stack = new Stack<string>();

        Console.WriteLine(list[0]);

        foreach (var item in Cities())
        {
            Console.WriteLine(item);
        };
    }

    private static IEnumerable<string> Cities()
    {
        yield return "München";
        yield return "Düsseldorf"; 
        yield return "Ulm";
    }

    static bool IsA(string s)
    {
        return s == "a";
    }
}

public static class EnumerableUtils
{
   public static IEnumerable<T> Fulfills<T>(this IEnumerable<T> source, Func<T, bool> condition)
    {
        List<T> result = new List<T>();
        foreach (var item in source)
        {
            if (condition(item) == true)
            {
                result.Add(item);
            }
        }
        return result;
    }

    public static IEnumerable<T> SortValues<T>(this IEnumerable<T> source)
    {
        return source;
    }

    public static IEnumerable<R> Project<T, R>(this IEnumerable<T> source)
    {
        return new List<R>();
    }
}

