
using Humanizer;
using System.Collections;
using System.Diagnostics;

namespace AppLib;

public class ApplicationInfo
{
    public event Action<bool>? Initialized; 

    public void Initialize()
    {
        // Initialisieren...
        Initialized?.Invoke(true);
    }

    public Dictionary<string, string> GetFolders()
    {
        Dictionary<string, string> result = new Dictionary<string, string>();

        foreach (var value in Enum.GetValues(typeof(Environment.SpecialFolder)))
        {
            // Lookup<string,string> hat zu einem Key eine Liste von Werten
            result[Enum.GetName(typeof(Environment.SpecialFolder), value)!] =
                Environment.GetFolderPath((Environment.SpecialFolder)value);
        }

        return result;
    }

    public Dictionary<string, string> GetVariables()
    {
        var result = new Dictionary<string, string>();

        foreach (DictionaryEntry entry in Environment.GetEnvironmentVariables())
        {
            if (entry.Key is string key && entry.Value is string value)
            {
                result[key] = value;
            }
        }

        return result;
    }

    public Dictionary<string,string> GetAdditionalInfo()
    {
        return new Dictionary<string, string>
        {
            ["UserName"] = Environment.UserName,
            ["CurrentDirectory"] = Environment.CurrentDirectory,
            ["OSVersion"] = Environment.OSVersion.VersionString,
            ["StartupPath"] = Environment.ProcessPath??"None",
            ["NetVersion"] = Environment.Version.ToString(),
            ["Memory"] = Process.GetCurrentProcess().WorkingSet64.Bytes().Humanize()
        };
    }

    public List<string> GetProcesses() => Process.GetProcesses().Select(p => p.ProcessName).Distinct().ToList();
}
