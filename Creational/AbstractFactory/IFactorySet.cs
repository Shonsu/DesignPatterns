namespace AbstractFactory;

public interface IFactorySet
{
    TableLamp CreateLamp();
    Table CreateTable();
}