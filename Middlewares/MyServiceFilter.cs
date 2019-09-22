using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace DotnetTutorial.Middlewares
{
    public class MyServiceFilter:ActionFilterAttribute
    {
         public override void OnActionExecuting (ActionExecutingContext context) {

              context.Result = new RedirectToRouteResult (new RouteValueDictionary (new { action = "Error", controller = "Home", area = "" }));
         }

    }
}