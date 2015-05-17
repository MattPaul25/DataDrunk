using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataDrunk.Controllers
{
    public class AppsController : Controller
    {
        // GET: App

        private string raw = "raw";

        public ActionResult Index(string style)
        {

            ViewBag.Message = "Welcome to the App Page section - Will be adding to this soon!";
            if (style != null && style == raw)
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }
    }
}