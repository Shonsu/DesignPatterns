namespace Observer;

public class Subscriber : ISubscriber
{
    public string Name { get; set; }

    public Subscriber(string name)
    {
        Name = name;
    }

    public void Update(string context)
    {
        System.Console.WriteLine($"{Name} receive notifiction about: {context}");
    }
}
