namespace Facade;

public class ScanFacade
{
    private QualityScanner _qualityScanner = new QualityScanner();
    private SecurityScanner _securityScanner = new SecurityScanner();
    private DependencyScanner _dependencyScanner = new DependencyScanner();
    private ReportGernerator _reportGernerator = new ReportGernerator();

    public void Scan(string ghUrl)
    {
        System.Console.WriteLine($"Scanning {ghUrl}");
        var qualityScanErrors = _qualityScanner.QualityScan(ghUrl);
        var securityScanErrors = _securityScanner.SecurityScan(ghUrl);
        var dependencyScanErrors = _dependencyScanner.DependencyScan(ghUrl);
        _reportGernerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
    }
}
