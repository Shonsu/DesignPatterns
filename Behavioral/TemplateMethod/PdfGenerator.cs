namespace TemplateMethod;

public class PdfGenerator : Generator
{
    protected override void GetData()
    {
        System.Console.WriteLine("Gatheriong data for pdf");
    }

    protected override void GenerateFile()
    {
        System.Console.WriteLine("Generate PDF file");
    }

    protected override void PrepareData()
    {
        System.Console.WriteLine("Prepare data for PDF");
    }
}
