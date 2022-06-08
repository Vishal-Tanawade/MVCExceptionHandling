# MVCExceptionHandling
## Asp .Net Web Application (.Net Framework)
- Date: 06- May- 2022
## Notes:
- we handle the Error without any try catch block 
- Just add below method in controller
- //This method is oveeride so if any error occured in application this Error page will be shown , we don't required to use try catch block

```
 protected override void OnException(ExceptionContext filterContext) 
        {
            ViewResult v = new ViewResult();
            v.ViewName = "Error"; //Error.cshtml page will be displayed
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
        }
```
### Handle Error in all controllers
- But above code will handle error only in that controller
- to handle error in all controllers do following thing:
1) Create another controller 
2) override above method in that controller
3) and inherit all other controllers from above controllers

Like this:
```
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
    //Some code.....
    ..
    ..
    ..
}
```

### Attribute Routing
- We don't required any try catch block or override any method

- Add below line in web.config in <b> <system.web></b> section
- If we make mode="RemoteOnly" error.cshtml page only shown to client side , but for developer we will see divide by zero error page
```
  <customErrors mode="On"/>
```
- Add below line in Global.asax.cs 
  ```
   GlobalFilters.Filters.Add(new HandleErrorAttribute()); 
  ```
 - Add below Keyword above controller name
  ```
   [HandleError] 
  ```
  - You can add custom exception page 
  - add below code in Global.asax.cs
  ```
            HandleErrorAttribute a1 = new HandleErrorAttribute();
            a1.ExceptionType = typeof(DivideByZeroException);
            a1.View = "DError";
            GlobalFilters.Filters.Add(a1);

            HandleErrorAttribute a2 = new HandleErrorAttribute();
            a1.ExceptionType = typeof(NullReferenceException);
            a1.View = "NRError";
            GlobalFilters.Filters.Add(a2);
  ```
  
  - Add below line to show custome page for exception
  
  ```
  [HandleError(ExceptionType=typeof(DivideByZeroException),View ="DError")]
  ```
  - to create our own Exception add below code in global.asax.cs class above
  ```
    public override void OnException(ExceptionContext filterContext)
        {
            ViewResult v = new ViewResult();
            v.ViewName = "MyErrorPage";
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
            Exception e = filterContext.Exception;
        }
  ```
  also add below line in global.asax.cs and comment default exceptionfilter line
  ```
   GlobalFilters.Filters.Add(new MyCustomExceptionFilter());
  ```
