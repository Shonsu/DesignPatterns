using Prototype;

Circle circle1 = new Circle()
{
    Radius = 5,
    x = 1,
    y = 2,
    Border = new Border() { Color = "Red", Size = "2px" }
};

Circle circle2 = (Circle)circle1.Clone();

System.Console.WriteLine("References circles: " + ReferenceEquals(circle1,circle2));
System.Console.WriteLine("References border in circles: " + ReferenceEquals(circle1.Border,circle2.Border));
