namespace Prototype
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            Rectangle cloneBase = (Rectangle)this.MemberwiseClone();
            cloneBase.Border = Border.Clone();
            return cloneBase;
        }

        public override void Render()
        {
            System.Console.WriteLine("Rendel rectangle");
        }
    }
}
