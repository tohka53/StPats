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
    public class Tanks_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        //private StPatsEntities db = new StPatsEntities();
        // GET: Tanks_StPats
        public ActionResult Index()
        {
            var tanks_StPats = db.Tanks_StPats.Include(t => t.Locations_StPats);
            return View(tanks_StPats.ToList());
        }

        // GET: Tanks_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tanks_StPats tanks_StPats = db.Tanks_StPats.Find(id);
            if (tanks_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tanks_StPats);
        }

        // GET: Tanks_StPats/Create
        public ActionResult Create()
        {
            ViewBag.location = new SelectList(db.Locations_StPats, "id_location", "description");
            return View();
        }

        // POST: Tanks_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tanque,codigo_tanque,capacidad,bottom_valve,manway,lifting_arm,vent,replacemnet_infiatable_gasket,price,stok,location,manual,image,desription")] Tanks_StPats tanks_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Tanks_StPats.Add(tanks_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.location = new SelectList(db.Locations_StPats, "id_location", "description", tanks_StPats.location);
            return View(tanks_StPats);
        }

        // GET: Tanks_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tanks_StPats tanks_StPats = db.Tanks_StPats.Find(id);
            if (tanks_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.location = new SelectList(db.Locations_StPats, "id_location", "description", tanks_StPats.location);
            return View(tanks_StPats);
        }

        // POST: Tanks_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tanque,codigo_tanque,capacidad,bottom_valve,manway,lifting_arm,vent,replacemnet_infiatable_gasket,price,stok,location,manual,image,desription")] Tanks_StPats tanks_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tanks_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.location = new SelectList(db.Locations_StPats, "id_location", "description", tanks_StPats.location);
            return View(tanks_StPats);
        }

        // GET: Tanks_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tanks_StPats tanks_StPats = db.Tanks_StPats.Find(id);
            if (tanks_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tanks_StPats);
        }

        // POST: Tanks_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tanks_StPats tanks_StPats = db.Tanks_StPats.Find(id);
            db.Tanks_StPats.Remove(tanks_StPats);
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
