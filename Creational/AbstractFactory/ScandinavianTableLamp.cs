namespace AbstractFactory;

public class ScandinavianTableLamp : TableLamp
{
    public void ChangeBrightness()
    {
        System.Console.WriteLine("Change brightness for scandinavian lamp.");
    }

    public void ChangeLightColor()
    {
        System.Console.WriteLine("Change light color for scandinavian lamp.");
    }
}