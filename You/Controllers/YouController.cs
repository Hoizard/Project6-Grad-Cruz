using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace You.Controllers
{
    public class YouController : Controller
    {
        // GET: You
        public ActionResult Index()
        {
            return View();
        }

        // GET: You/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: You/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: You/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: You/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: You/Edit/5
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

        // GET: You/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: You/Delete/5
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
