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
    public class Lista_Productos_StPatsController : Controller
    {
        private StPatsDataBaseEntities db = new StPatsDataBaseEntities();

        // GET: Lista_Productos_StPats
        public ActionResult Index()
        {
            var lista_Productos_StPats = db.Lista_Productos_StPats.Include(l => l.Estado_StPats).Include(l => l.Productos_StPats);
            return View(lista_Productos_StPats.ToList());
        }

        // GET: Lista_Productos_StPats/Details/5
        public ActionResult Details(long? id,[Bind(Include = "id_lista_producto,id_producto,id_cantidad,precio_unitario,precio_total,id_estado,date")] Lista_Productos_StPats lista_Productos_St)
        {
            
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Lista_Productos_StPats lista_Productos_StPats = db.Lista_Productos_StPats.Find(id);
           

            if (lista_Productos_StPats == null)
            {
                return HttpNotFound();
            }
            return View(lista_Productos_StPats);
        }

        // GET: Lista_Productos_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_producto = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            return View();
        }

        // POST: Lista_Productos_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_lista_producto,id_producto,id_cantidad,precio_unitario,precio_total,id_estado,date")] Lista_Productos_StPats lista_Productos_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Lista_Productos_StPats.Add(lista_Productos_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", lista_Productos_StPats.id_estado);
            ViewBag.id_producto = new SelectList(db.Productos_StPats, "id_producto", "codigo", lista_Productos_StPats.id_producto);
            return View(lista_Productos_StPats);
        }

        // GET: Lista_Productos_StPats/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lista_Productos_StPats lista_Productos_StPats = db.Lista_Productos_StPats.Find(id);
            if (lista_Productos_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", lista_Productos_StPats.id_estado);
            ViewBag.id_producto = new SelectList(db.Productos_StPats, "id_producto", "codigo", lista_Productos_StPats.id_producto);
            return View(lista_Productos_StPats);
        }

        // POST: Lista_Productos_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_lista_producto,id_producto,id_cantidad,precio_unitario,precio_total,id_estado,date")] Lista_Productos_StPats lista_Productos_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lista_Productos_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", lista_Productos_StPats.id_estado);
            ViewBag.id_producto = new SelectList(db.Productos_StPats, "id_producto", "codigo", lista_Productos_StPats.id_producto);
            return View(lista_Productos_StPats);
        }

        // GET: Lista_Productos_StPats/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lista_Productos_StPats lista_Productos_StPats = db.Lista_Productos_StPats.Find(id);
            if (lista_Productos_StPats == null)
            {
                return HttpNotFound();
            }
            return View(lista_Productos_StPats);
        }

        // POST: Lista_Productos_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Lista_Productos_StPats lista_Productos_StPats = db.Lista_Productos_StPats.Find(id);
            db.Lista_Productos_StPats.Remove(lista_Productos_StPats);
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
