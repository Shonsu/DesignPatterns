namespace AbstractFactory;

public class ScandinavianFactory: IFactorySet
{
public TableLamp CreateLamp()
{
    return new ScandinavianTableLamp();
}

public Table CreateTable()
{
    return new ScandinavianTable();
}
}