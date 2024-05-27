namespace AbstractFactory;

public class Plane : IFlyingMachine
{
    public string Land()
    {
        return "Plane landing";
    }

    public string TakeOf()
    {
        return "Plane taking off";
    }
}