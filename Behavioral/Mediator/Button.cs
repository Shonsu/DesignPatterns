namespace Mediator;

public class Button : Component
{
    public void Render()
    {
        System.Console.WriteLine("Render button");
    }

    public void Click()
    {
        System.Console.WriteLine("Button click");
        this._mediator.Notify(this, "click");
    }
}
