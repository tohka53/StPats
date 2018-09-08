using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StPats.Models
{
    public class TanksController : Controller
    {
        // GET: Tanks
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tanks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tanks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tanks/Create
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

        // GET: Tanks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tanks/Edit/5
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

        // GET: Tanks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tanks/Delete/5
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
