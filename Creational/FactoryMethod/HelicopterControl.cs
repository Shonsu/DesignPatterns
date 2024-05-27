namespace AbstractFactory;

public class HelicopterControl : FlightControl
{
    public override IFlyingMachine FactoryMethod()
    {
        return new Helicopter();
    }
}
