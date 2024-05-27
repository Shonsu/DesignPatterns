namespace ChainOfResponsibility;

public class AuthorizationHandler : BaseHandler
{
    private Dictionary<int, int> entityOwners = new Dictionary<int, int>()
    {
        { 100, 13 },
        { 101, 14 }
    };

    public AuthorizationHandler(IHandler next)
        : base(next) { }

    public override void Handle(RequestContext requestContext)
    {
        System.Console.WriteLine("AuthorizationHandler");
        if (entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
        {
            if (ownerId == requestContext.Request.UserId)
            {
                System.Console.WriteLine("Is OWner");
                _next.Handle(requestContext);
                return;
            }
        }
        if (requestContext.Request.UserRole == "Admin")
        {
            System.Console.WriteLine("Is Admin");
            _next.Handle(requestContext);
            return;
        }

        requestContext.Response.IsSuccessful = false;
        requestContext.Response.Message = "User not auhorized";
    }
}
