namespace AbstractFactory;

public class Factory
{
    private readonly IFactorySet factorySet;

    public Factory(IFactorySet factorySet)
    {
        this.factorySet = factorySet;
    }

    public void CreateSet(){
        TableLamp tableLamp = this.factorySet.CreateLamp();
        tableLamp.ChangeBrightness();
        Table table = this.factorySet.CreateTable();
        table.ChangeSize();
    }
}