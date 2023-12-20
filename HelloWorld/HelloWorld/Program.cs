using System.Xml.Linq;
namespace HelloWorld;

/// <summary>
/// Die Klasse Programm ist der Einstieg in unsere Applikation
/// </summary>
internal class Program
{
    /// <summary>
    /// Main läuft automatisch los
    /// </summary>
    /// <param name="args">Die übergebenen Argumente</param>
    static void Main(string[] args)
    {
        double pi = 3.14;
        int drei = (int) pi;
        double three = drei;

        Console.WriteLine("{0:f2}", three);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("{0:d.MMMM yy (H:mm:ss,fff)}", DateTime.Now);

        var k = Math.Pow(2, 10);


        Console.WriteLine("Bitte Namen eingeben");
        string? input = Console.ReadLine();

        Console.WriteLine("Hello {0}, welcome to C# World!", input);
        Console.WriteLine($"Hello {input}, {input?.Length}, welcome to {3*4} C# World!");

        string numberAsString = Console.ReadLine()!;
        if(int.TryParse(numberAsString, out int number))
        {
            Console.WriteLine(number);
        }

        int value = int.Parse( numberAsString );

        Console.WriteLine(value);
        File.WriteAllText("out.txt", input);

        XElement x = new XElement("hello");
    }

    static string Hi()
    {
        return "Hi";
    }
}
