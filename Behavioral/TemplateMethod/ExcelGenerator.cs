namespace TemplateMethod;

public class ExcelGenerator : Generator
{
    protected override void GenerateFile()
    {
        System.Console.WriteLine("Generate excel file");
    }

    protected override void PrepareData()
    {
        System.Console.WriteLine("Prepare data for excell");
    }
}
