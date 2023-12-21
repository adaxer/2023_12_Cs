using System.Collections;

namespace Utils;

class Program
{
    static void Main(string[] args)
    {
        //Console.Clear();

        // Environment
        // Console.CursorTop = 10;

        // Environment Variables

        Console.ForegroundColor = ConsoleColor.Blue;
        foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            Console.WriteLine("  {0} = {1}", de.Key, de.Value);


        // Specialfolderd

        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (var folder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            Console.WriteLine($"{Enum.GetName(typeof(Environment.SpecialFolder), folder)}:  {Environment.GetFolderPath((Environment.SpecialFolder)folder)}");


        // Maschine, User, Prozesspfad, OsVersion, CurrentDirectory, Processorcount

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Environment.ProcessPath);
        Console.WriteLine(Environment.MachineName);
        Console.WriteLine(Environment.UserName);
    }
}
