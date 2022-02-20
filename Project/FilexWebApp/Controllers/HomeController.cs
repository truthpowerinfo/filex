using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilexWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Privacy()
        {
            return View("Privacy", "_LayoutSite");
        }
        public ActionResult Disclaimer()
        {
            return View("Disclaimer", "_LayoutSite");
        }
        public ActionResult Terms()
        {
            return View("Terms", "_LayoutSite");
        }
        public ActionResult Support()
        {
            return View("Support", "_LayoutSite");
        }
        public ActionResult Tools()
        {
            return View();
        }
    }
}