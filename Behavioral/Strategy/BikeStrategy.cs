namespace Strategy;

public class BikeStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        System.Console.WriteLine("Create bike strategy between {0} and {1}.", start, end);
    }
}
