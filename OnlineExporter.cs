public class OnlineEporter : DocumentExporter
{
    public override void ExportToPDF()
    {
        throw new NotSupportedException("OnlineExporter cannot export to PDF!");
    }

    public void ExportToHTML()
    {
        Console.WriteLine("Exported to HTML successfully.");
    }
}