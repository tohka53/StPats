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
    public class Estado_StPatsController : Controller
    {
        private StPatsDataBaseEntities1 db = new StPatsDataBaseEntities1();

        // GET: Estado_StPats
        public ActionResult Index()
        {
            return View(db.Estado_StPats.ToList());
        }

        // GET: Estado_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_StPats estado_StPats = db.Estado_StPats.Find(id);
            if (estado_StPats == null)
            {
                return HttpNotFound();
            }
            return View(estado_StPats);
        }

        // GET: Estado_StPats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_estado,descripcion")] Estado_StPats estado_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Estado_StPats.Add(estado_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado_StPats);
        }

        // GET: Estado_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_StPats estado_StPats = db.Estado_StPats.Find(id);
            if (estado_StPats == null)
            {
                return HttpNotFound();
            }
            return View(estado_StPats);
        }

        // POST: Estado_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_estado,descripcion")] Estado_StPats estado_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estado_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado_StPats);
        }

        // GET: Estado_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estado_StPats estado_StPats = db.Estado_StPats.Find(id);
            if (estado_StPats == null)
            {
                return HttpNotFound();
            }
            return View(estado_StPats);
        }

        // POST: Estado_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estado_StPats estado_StPats = db.Estado_StPats.Find(id);
            db.Estado_StPats.Remove(estado_StPats);
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
