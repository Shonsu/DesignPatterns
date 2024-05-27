namespace AbstractFactory;

public class PlaneControl : FlightControl
{
    public override IFlyingMachine FactoryMethod()
    {
        return new Plane();
    }
}