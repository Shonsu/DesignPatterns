namespace Facade;

public class SecurityScanner
{
    public IEnumerable<string> SecurityScan(string ghUrl)
    {
        System.Console.WriteLine("Security scan");
        return new List<string>() { "security error 1" };
    }
}
