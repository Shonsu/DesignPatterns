namespace Prototype;

public abstract class Shape
{
    public int x { get; set; }
    public int y { get; set; }

    public Border Border { get; set; }

    public abstract void Render();
    public abstract Shape Clone();
}
