using System.Diagnostics;

namespace AppLib;
public static class ProcessStarter
{
    public static void Start(string path)
    {
        Process.Start(path);
    }
}
