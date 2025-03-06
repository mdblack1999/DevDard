using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public ContentResult Index()
        //{
        //    return Content(@"<h1 style ='color:red;' > Hello I`m Mohammad Fallahi</h1>" , "text/html");
        //}
        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/Files/Robots.txt");
        //    return File(fileByte, "text/html", "Robots.txt");
        //}
        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 1,
        //        name = "mohammad",
        //        job="Programmer",
        //        age =25,
        //        telegramId = "mdblackk1999"
        //    });
        //}

        // ----- this method reWrite by Class JavaScript ------
        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("setTimeout(function(){alert(\"This is Delayed Message by Js\"); },1500)");
        //}
        //public IActionResult Index()
        //{
        //        //return new OkResult();
        //        //return new StatusCodeResult(503);
        //        //return new NoContentResult();
        //    return new NotFoundResult();
        //}
        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}
    }

    //------  this secction for JvaScriptResult --------
    //public class JavaScriptResult : ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/Javascript";
    //    }
    //}
}
