namespace ChainOfResponsibility;

public class ResultHandler : BaseHandler
{
    public ResultHandler(IHandler next)
        : base(next) { }

    public override void Handle(RequestContext requestContext)
    {
        System.Console.WriteLine("ResultHandler");
        requestContext.Response.IsSuccessful = true;
        requestContext.Response.Data = "some value";
    }
}
