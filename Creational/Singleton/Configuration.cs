namespace Singleton;

public class Configuration
{
    private static Configuration _instance = null;
    private static readonly object _lock = new object();
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }

    private Configuration() { }

    public static Configuration GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new Configuration();
            }
        }
        return _instance;
    }
}
