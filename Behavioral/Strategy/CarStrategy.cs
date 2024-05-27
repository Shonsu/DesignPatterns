namespace Strategy;

public class CarStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        System.Console.WriteLine("Create car strategy between {0} and {1}.", start, end);
    }
}