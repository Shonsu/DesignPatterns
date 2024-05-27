﻿using System.Security.Cryptography;

namespace ChainOfResponsibility;

public abstract class BaseHandler : IHandler
{
    protected IHandler _next;

    protected BaseHandler(IHandler next)
    {
        _next = next;
    }

    public abstract void Handle(RequestContext requestContext);
}
