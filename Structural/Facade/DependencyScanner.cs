namespace Facade;

public class DependencyScanner
{
    public List<string> DependencyScan(string ghUrl)
    {
        System.Console.WriteLine("Dependency scan");
        return new List<string>() { "dependencyScan err1", "dependencyScan err2" };
    }
}
