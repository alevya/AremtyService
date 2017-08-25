using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebApp.CustomRouting
{
    public class CustomRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new CustomHttpHandler();
        }

        public class CustomHttpHandler : IHttpHandler
        {
            public void ProcessRequest(HttpContext context)
            {
                context.Response.Write("Test handler process");
            }

            public bool IsReusable { get { return false; } }
        }
    }
}