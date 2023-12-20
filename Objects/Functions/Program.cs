using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        OptionalExample(1, third: 2);
        Greeting();
        Greeting("Hello");
        int a = 1;
        if (a == 1)
        {
        }

        Increment(ref a);
        Console.WriteLine(a);

        int b;
        GetNumber(out b);

        Empty();
        string name = GetName();
        Console.WriteLine(name);

        DumpValues(1, true, "hello", new object());
        DumpValues(true, new object(), DateTime.Now.AddDays(1));
        DumpValuesBetter(1);
        DumpValuesBetter(true, DateTime.UtcNow, "");

        Console.ReadLine();
        // Programm-Ende
    }

    private static void OptionalExample(int first, int second=1, int third=1)
    {

    }

    private static void Greeting(string greetingMessage = "Guten Tag")
    {
        Console.WriteLine(greetingMessage);
    }

    private static void GetNumber(out int result)
    {
        result = 42;
    }

    private static void Increment(ref int a)
    {
        a++;
    }

    private static void DumpValuesBetter(params object[] values)
    {
        foreach (var value in values)
        {
            Console.WriteLine($"{value.GetType().FullName}: {value}");
        };
    }

    static void DumpValues(bool v1, object v3, DateTime dateTime)
    {
        Console.WriteLine("3 Parameter");
    }

    // Überladene Methode
    static void DumpValues(int number, bool isIt, string chars, object something)
    {
        Console.WriteLine(number);
        Console.WriteLine(isIt);
        Console.WriteLine(chars);
        Console.WriteLine(something);
    }

    static string GetName()
    {
        void showMessage()
        {
            Console.WriteLine("Name bitte/danke:");
        }

        showMessage();
        return Console.ReadLine() ?? string.Empty; // null-coalescing operator

        //var result = Console.ReadLine();
        //if (result == null)
        //{
        //    return string.Empty;
        //}
        //return result;
    }

    private static void Empty()
    {
        // ...
    }

    // Lässt der Compiler nicht zu
    //private static bool Empty() 
    //{
    //    return false;
    //}
}
