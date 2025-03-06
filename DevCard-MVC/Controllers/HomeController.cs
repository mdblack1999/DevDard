using System;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    var email = form["email"];
        //    var service = form["service"];
        //    var message= form["message"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form);
            return Json(Ok());
        }

        [ResponseCache(Duration = 0 , Location = ResponseCacheLocation.None , NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
