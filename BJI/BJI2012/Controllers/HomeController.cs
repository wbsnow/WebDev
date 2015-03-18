using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BJI2012.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //<h2>@ViewBag.Message</h2>
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
