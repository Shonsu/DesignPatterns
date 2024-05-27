namespace AbstractFactory;

public class VintageTableLamp : TableLamp
{
    public void ChangeBrightness()
    {
        System.Console.WriteLine("Change brightness for vintage lamp.");
    }

    public void ChangeLightColor()
    {
        System.Console.WriteLine("Change light color for vintage lamp.");
    }
}
