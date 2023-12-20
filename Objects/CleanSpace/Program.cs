namespace CleanSpace;

internal class Program
{
    static void Main(string[] args)
    {
        string content = "Inhalt für eine Datei";

        using (StreamWriter writer = new StreamWriter("out.txt"))
        {
            writer.WriteLine("Hier kommen Daten");
            writer.WriteLine(content);
            // throw new Exception("No Ende");
            writer.WriteLine("Ende");
        }

        Write2ndFile();
        //StreamWriter? writer = null;
        //try
        //{
        //    writer = new StreamWriter("out.txt");
        //    writer.WriteLine("Hier kommen Daten");
        //    writer.WriteLine(content);
        //    writer.WriteLine("Ende");
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("Fehler (normal mit genaueren Angaben dazu)");
        //}
        //finally
        //{
        //    writer?.Close();
        //}
        ////writer.Dispose();
        Console.ReadLine();
    }

    static void Write2ndFile()
    {
        using var writer2 = new StreamWriter("out2.txt");
        writer2.WriteLine("was anderes");
    }
}
