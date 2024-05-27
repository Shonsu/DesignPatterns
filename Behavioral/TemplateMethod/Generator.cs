namespace TemplateMethod;

public abstract class Generator
{
    public void GenerateRaport(){
        GetData();
        PrepareData();
        GenerateFile();
        SendFile();
    }
    protected virtual void GetData()
    {
        System.Console.WriteLine("Base - Gathering data");
    }

    protected abstract void PrepareData();
    protected abstract void GenerateFile();

    protected void SendFile()
    {
        System.Console.WriteLine("Sending generated report");
    }
}
