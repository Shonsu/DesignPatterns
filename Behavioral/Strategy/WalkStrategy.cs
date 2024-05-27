namespace Strategy;

public class WalkStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        System.Console.WriteLine("Create walk strategy between {0} and {1}.", start, end);
    }
}
