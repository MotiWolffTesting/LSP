public class DocumentExporter : IPdfExporter
{
    public virtual void ExportToPDF()
    {
        Console.WriteLine("Exported to PDF successfully.");
    }
}