namespace AbstractFactory;

public abstract class FlightControl
{
    public abstract IFlyingMachine FactoryMethod();

    public string MachineLanding()
    {
        var flyingMachine = FactoryMethod();
        var result = "Prepare for " + flyingMachine.Land();

        return result;
    }

    public string MachineTakingOfff()
    {
        var flyingMachine = FactoryMethod();
        var result = "Prepare for " + flyingMachine.TakeOf();

        return result;
    }
}
