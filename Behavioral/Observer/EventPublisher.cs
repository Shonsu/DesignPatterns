using System.Collections.Immutable;

namespace Observer;

public class EventPublisher
{
    private Dictionary<Category, List<ISubscriber>> Subscribers { get; set; } = [];

    public void Subscribe(Category category, ISubscriber newSubscriber)
    {
        if (!Subscribers.ContainsKey(category))
        {
            Subscribers.Add(category, new List<ISubscriber>());
        }
        Subscribers.TryGetValue(category, out List<ISubscriber>? list);
        list!.Add(newSubscriber);
    }

    public void Unsubscribe(Category category, ISubscriber subscriber)
    {
        List<ISubscriber>? subscribers = this.Subscribers.GetValueOrDefault(category);
        if (subscribers != null)
        {
            subscribers.Remove(subscriber);
        }
    }

    public void Notify(String context)
    {
        var list = Subscribers[context.ToEnum(Category.CONCERT)];
        list.ForEach(s => s.Update(context));
    }
}
