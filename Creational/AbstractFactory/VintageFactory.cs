namespace AbstractFactory;

public class VintageFactory : IFactorySet
{
    public TableLamp CreateLamp()
    {
        return new VintageTableLamp();
    }

    public Table CreateTable()
    {
        return new VintageTable();
    }
}
