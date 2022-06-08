using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCExceptionHandling
{
    public class MyCustomExceptionFilter: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            ViewResult v = new ViewResult();
            v.ViewName = "MyErrorPage";
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
            Exception e = filterContext.Exception;
        }

    }

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            HandleErrorAttribute a1 = new HandleErrorAttribute();
            a1.ExceptionType = typeof(DivideByZeroException);
            a1.View = "DError";
            GlobalFilters.Filters.Add(a1);

            HandleErrorAttribute a2 = new HandleErrorAttribute();
            a1.ExceptionType = typeof(NullReferenceException);
            a1.View = "NRError";
            GlobalFilters.Filters.Add(a2);

            //To show default error msg
           //   GlobalFilters.Filters.Add(new HandleErrorAttribute()); ////For Attribute error handling 
            GlobalFilters.Filters.Add(new MyCustomExceptionFilter());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
