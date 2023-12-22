using AppLib;
using MiniLib;

namespace ConsoleClient;

internal class Program
{
    static void Main(string[] args)
    {
        var miniclass = new Class1();
        ApplicationInfo info = new ApplicationInfo();

        Dictionary<string, string> folders = info.GetFolders();

        Console.CursorTop = 10;
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (string folder in folders.Keys)
        {
            Console.WriteLine($"{folder}: {folders[folder]}");
        }

        var variables = info.GetVariables();
        Console.ForegroundColor = ConsoleColor.Blue;
        foreach (string variable in variables.Keys)
        {
            Console.WriteLine($"{variable}: {variables[variable]}");
        }

        var additional = info.GetAdditionalInfo();
        Console.ForegroundColor = ConsoleColor.Yellow;
        foreach (string key in additional.Keys)
        {
            Console.WriteLine(key + "=" + additional[key]);
        }

        var processes = info.GetProcesses();
        Console.ForegroundColor = ConsoleColor.Red;
        foreach (var name in processes)
        {
            Console.WriteLine(name);
        }

        Console.ResetColor();

        ProcessStarter.Start("notepad");
        
        Console.ReadLine();
    }
}
