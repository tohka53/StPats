using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StPats.Models;

namespace StPats.Controllers
{
    public class Locations_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        // private StPatsEntities db = new StPatsEntities();
        // GET: Locations_StPats
        public ActionResult Index()
        {
            return View(db.Locations_StPats.ToList());
        }

        // GET: Locations_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locations_StPats locations_StPats = db.Locations_StPats.Find(id);
            if (locations_StPats == null)
            {
                return HttpNotFound();
            }
            return View(locations_StPats);
        }

        // GET: Locations_StPats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locations_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_location,description")] Locations_StPats locations_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Locations_StPats.Add(locations_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locations_StPats);
        }

        // GET: Locations_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locations_StPats locations_StPats = db.Locations_StPats.Find(id);
            if (locations_StPats == null)
            {
                return HttpNotFound();
            }
            return View(locations_StPats);
        }

        // POST: Locations_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_location,description")] Locations_StPats locations_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locations_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locations_StPats);
        }

        // GET: Locations_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locations_StPats locations_StPats = db.Locations_StPats.Find(id);
            if (locations_StPats == null)
            {
                return HttpNotFound();
            }
            return View(locations_StPats);
        }

        // POST: Locations_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Locations_StPats locations_StPats = db.Locations_StPats.Find(id);
            db.Locations_StPats.Remove(locations_StPats);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
