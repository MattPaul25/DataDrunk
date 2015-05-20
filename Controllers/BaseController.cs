using DataDrunk.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataDrunk.Controllers
{
    public class BaseController : Controller
    {
        private string raw = "raw";
       

        public ActionResult About(string style)
        {
            ViewBag.Message = "About";
            if (style != null && style.ToLower() == raw)
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }
        public ActionResult json()
        
        {
             var myJson = Json(new { name = "Matt Farguson",  twitter = "MattPaul25",
                                website = "DataDrunk.Com"}, JsonRequestBehavior.AllowGet );
             return myJson;
                            
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Having Trouble?";
            return View();            
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Thank You for submitting your message.";            
             return View();
            
        }
        public ActionResult Downloads(string direct)
        {

            if(direct != null || direct != "")
            {
                ViewBag.Direct = direct;
                return View();
            }
            else
            {
                ViewBag.Direct = "";
                return View();
            }
        }
       
        public ActionResult Home(string style)
        {

            if (style != null && style.ToLower() == raw)
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }
        public ActionResult Index(string style)
        {
            if (style != null && style.ToLower() == raw)
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