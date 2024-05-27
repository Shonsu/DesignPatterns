using TemplateMethod;

var pdfGenerator = new PdfGenerator();

System.Console.WriteLine("** PDF **");
pdfGenerator.GenerateRaport();

var csvGenerator = new CsvGenerator();

System.Console.WriteLine("** Csv **");
csvGenerator.GenerateRaport();