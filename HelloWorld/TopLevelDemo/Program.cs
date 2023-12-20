// eigentlich unsauber, aber Teil von C#
using System.Diagnostics;

goto doSwitch;

bool proceed = true;
while (proceed)
{
    Console.WriteLine("Wert eingeben");
    string? input1 = Console.ReadLine();

    proceed = !string.IsNullOrEmpty(input1);
    if (proceed)
    {
        Console.WriteLine($"Hello {input1}");
    }
}

string? input;
do
{
    Console.WriteLine("Wert eingeben");
    input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        Console.WriteLine($"Hello {input}");
    }
} while (!string.IsNullOrEmpty(input));

doSwitch:

DayOfWeek today = DayOfWeek.Tuesday;

switch (today)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Wochenende: Ausflug angesagt");
        break;
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
    case DayOfWeek.Thursday:
    case DayOfWeek.Friday:
        Console.WriteLine("Ab ins Büro");
        break;
    default:
        Trace.TraceWarning("Hier sollten wir nie landen - Logik überprüfen?");
        break;
}

Console.WriteLine("Ende");
Console.ReadLine();