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
    public class Tipo_Producto_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        // private StPatsEntities db = new StPatsEntities();
        // GET: Tipo_Producto_StPats
        public ActionResult Index()
        {
            return View(db.Tipo_Producto_StPats.ToList());
        }

        // GET: Tipo_Producto_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Producto_StPats tipo_Producto_StPats = db.Tipo_Producto_StPats.Find(id);
            if (tipo_Producto_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Producto_StPats);
        }

        // GET: Tipo_Producto_StPats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo_Producto_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tipo_producto,descripcion_producto")] Tipo_Producto_StPats tipo_Producto_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Tipo_Producto_StPats.Add(tipo_Producto_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_Producto_StPats);
        }

        // GET: Tipo_Producto_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Producto_StPats tipo_Producto_StPats = db.Tipo_Producto_StPats.Find(id);
            if (tipo_Producto_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Producto_StPats);
        }

        // POST: Tipo_Producto_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tipo_producto,descripcion_producto")] Tipo_Producto_StPats tipo_Producto_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_Producto_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_Producto_StPats);
        }

        // GET: Tipo_Producto_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Producto_StPats tipo_Producto_StPats = db.Tipo_Producto_StPats.Find(id);
            if (tipo_Producto_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Producto_StPats);
        }

        // POST: Tipo_Producto_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tipo_Producto_StPats tipo_Producto_StPats = db.Tipo_Producto_StPats.Find(id);
            db.Tipo_Producto_StPats.Remove(tipo_Producto_StPats);
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
