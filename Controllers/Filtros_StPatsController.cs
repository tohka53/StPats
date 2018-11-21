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
    public class Filtros_StPatsController : Controller
    {
       private StPatsDataBaseEntities1 db = new StPatsDataBaseEntities1();
        // private StPatsEntities db = new StPatsEntities();
        // GET: Filtros_StPats
        public ActionResult Index()
        {
            return View(db.Filtros_StPats.ToList());
        }

        // GET: Filtros_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filtros_StPats filtros_StPats = db.Filtros_StPats.Find(id);
            if (filtros_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filtros_StPats);
        }

        // GET: Filtros_StPats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filtros_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_filtro,filtro_codigo,numero_plates,area_superficie,precio")] Filtros_StPats filtros_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Filtros_StPats.Add(filtros_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filtros_StPats);
        }

        // GET: Filtros_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filtros_StPats filtros_StPats = db.Filtros_StPats.Find(id);
            if (filtros_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filtros_StPats);
        }

        // POST: Filtros_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_filtro,filtro_codigo,numero_plates,area_superficie,precio")] Filtros_StPats filtros_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filtros_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filtros_StPats);
        }

        // GET: Filtros_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filtros_StPats filtros_StPats = db.Filtros_StPats.Find(id);
            if (filtros_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filtros_StPats);
        }

        // POST: Filtros_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filtros_StPats filtros_StPats = db.Filtros_StPats.Find(id);
            db.Filtros_StPats.Remove(filtros_StPats);
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
