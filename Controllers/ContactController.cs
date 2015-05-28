using DataDrunk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataDrunk.Controllers
{
    public class ContactController : Controller
    {
        private MyDbContext db = new MyDbContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // GET: Contact/Details/5
        public ActionResult Details()
        {
            //todo: make work
            var x = new DataDrunk.Models.MessageModel { Email = "test", Id = 1, Message = "hello", Name = "Matt" };
            return View(x);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(MessageModel myMessage)
        {
            //try
            //{
                db.Message.Add(myMessage);
                db.SaveChanges();

                return RedirectToAction("Submitted");
            //}
            //catch
            //{
            //    return View();
            //}
        }
        public ActionResult Submitted()
        {
            ViewBag.Message = "Thank you for submitting your question.";
            return View();
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
