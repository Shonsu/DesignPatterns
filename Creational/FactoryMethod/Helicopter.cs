namespace AbstractFactory;

public class Helicopter : IFlyingMachine
{
    public string Land()
    {
        return "Helicopter landing";
    }

    public string TakeOf()
    {
        return "Helicopter taking off";
    }
}
