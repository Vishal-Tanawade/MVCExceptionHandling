using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandling.Controllers
{

    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            ViewResult v = new ViewResult();
            v.ViewName = "Error";
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
        }

    }

    public class HomeController : BaseController
    {
        //protected override void OnException(ExceptionContext filterContext) //This method is oveeride so if any error occured in application this Error page will be shown , we don't required to use try catch block
        //{
        //    ViewResult v = new ViewResult();
        //    v.ViewName = "Error"; //Error.cshtml page will be displayed
        //    filterContext.Result = v;
        //    filterContext.ExceptionHandled = true;
        //}
        public ActionResult Index()
        { //try
          //{
            int i = 0;
            int num = 10;
            i = num / i;
            return View();
            //    }
            //        catch(Exception e) { 

            //            return View("Error");
            //}
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}