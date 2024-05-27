namespace Strategy;

public class Map
{
    private readonly IRouteStrategy routeStrategy;

    public Map(IRouteStrategy routeStrategy)
    {
        this.routeStrategy = routeStrategy;
    }

    public void CreateRoute(Coordinate start, Coordinate end)
    {
        routeStrategy.CreateRoute(start, end);
    }
}
