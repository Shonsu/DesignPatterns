namespace Facade;

public class ReportGernerator
{
    public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
    {
        System.Console.WriteLine("qualityScanErrors");
        System.Console.WriteLine(string.Join(", ", qualityScanErrors));

        System.Console.WriteLine("securityScanErrors");
        System.Console.WriteLine(string.Join(", ", securityScanErrors));

        System.Console.WriteLine("dependencyScanErrors");
        System.Console.WriteLine(string.Join(", ", dependencyScanErrors));
    }
}
