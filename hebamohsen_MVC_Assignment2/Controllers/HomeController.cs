using Microsoft.AspNetCore.Mvc;

namespace hebamohsen_MVC_Assignment2.Controllers
{
    public class HomeController : Controller
    {
        //public ContentResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "Hello From Content Result";
        //    return contentResult;
        //}

        //public ActionResult AbouteUs()
        //{
        //    return Redirect("https://www.google.com/webhp?authuser=0#sbfbu=1&pi=");
        //}

        //public ActionResult Content()
        //{
        //    return Content("Hello From Content");
        //}

        //public ActionResult About()
        //{
        //    return RedirectToAction("Index");
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Content()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
