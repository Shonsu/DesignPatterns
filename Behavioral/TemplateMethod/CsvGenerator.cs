namespace TemplateMethod;

public class CsvGenerator : Generator
{
    protected override void GenerateFile()
    {
        System.Console.WriteLine("Generate Csv file");
    }

    protected override void PrepareData()
    {
        System.Console.WriteLine("Prepare data for Csv");
    }
}
