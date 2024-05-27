using ChainOfResponsibility;

RequestContext requestContext = new RequestContext()
{
    Request = new Request()
    {
        EntityId = 101,
        UserId = 14,
        UserRole = "User"
    },
    Response = new Response()
};

var resultHandler = new ResultHandler(null);
var validationHandler = new ValidationHandler(resultHandler);
var authorizationHandler = new AuthorizationHandler(validationHandler);

authorizationHandler.Handle(requestContext);

System.Console.WriteLine($"Is Successful: {requestContext.Response.IsSuccessful}");
System.Console.WriteLine($"Message: {requestContext.Response.Message}");
System.Console.WriteLine($"Data: {requestContext.Response.Data}");
