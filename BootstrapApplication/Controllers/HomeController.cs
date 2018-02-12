using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult CalcApp(string numA, string numB, string operation)
        {
            var result = 0;
            var x = 0;
            var y = 0;
            if (numA != null && numB != null && operation != null) {
                x = int.Parse(numA);
                y = int.Parse(numB);
                switch (operation) {
                    case "add":
                        result = x + y;
                        break;
                    case "subtract":
                        result = x - y;
                        break;
                    case "multiply":
                        result = x * y;
                        break;
                    case "divide":
                        result = x / y;
                        break;
                }
            }

            return View("CalcApp", result);
        }
    }
}