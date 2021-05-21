using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace WebApplication1.Controllers.Filter
{
        public class UserFilter : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext c)
            {
            int? id = c.HttpContext.Session.GetInt32("id");
            if (!id.HasValue)
            {
                c.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"action","Index" },
                    {"controller","Login" }

                });
            }
            base.OnActionExecuting(c);
        }
        }
    
}
