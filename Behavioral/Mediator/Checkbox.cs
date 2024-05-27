namespace Mediator;

public class Checkbox : Component
{
    public void Select()
    {
        System.Console.WriteLine("Checkbox selected.");
        this._mediator.Notify(this, "checkboxSelected");
    }

    public void SaveValue()
    {
        System.Console.WriteLine("Checkbox value saved.");
    }
}
