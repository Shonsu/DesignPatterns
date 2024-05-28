namespace Facade;

public class QualityScanner
{
    public IEnumerable<string> QualityScan(string ghUrl)
    {
        System.Console.WriteLine("Quality scan");
        return new List<string>() { "error1", "error2" };
    }
}
