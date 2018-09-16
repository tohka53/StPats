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
    public class Productos_StPatsController : Controller
    {
        private StPatsDataBaseEntities db = new StPatsDataBaseEntities();

        // GET: Productos_StPats
        public ActionResult Index()
        {
            var productos_StPats = db.Productos_StPats.Include(p => p.Estado_StPats).Include(p => p.Locations_StPats).Include(p => p.Tipo_Producto_StPats);
            return View(productos_StPats.ToList());
        }

        // GET: Productos_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos_StPats productos_StPats = db.Productos_StPats.Find(id);
            if (productos_StPats == null)
            {
                return HttpNotFound();
            }
            return View(id);
        }
 

        // GET: Productos_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_tipo_producto = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Productos_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_producto,id_tipo_producto,codigo,price,stock,description,id_location,image,id_estado,manual,stock_menos_carrito")] Productos_StPats productos_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Productos_StPats.Add(productos_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", productos_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", productos_StPats.id_location);
            ViewBag.id_tipo_producto = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", productos_StPats.id_tipo_producto);
            return View(productos_StPats);
        }

        // GET: Productos_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos_StPats productos_StPats = db.Productos_StPats.Find(id);
            if (productos_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", productos_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", productos_StPats.id_location);
            ViewBag.id_tipo_producto = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", productos_StPats.id_tipo_producto);
            return View(productos_StPats);
        }

        // POST: Productos_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_producto,id_tipo_producto,codigo,price,stock,description,id_location,image,id_estado,manual,stock_menos_carrito")] Productos_StPats productos_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", productos_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", productos_StPats.id_location);
            ViewBag.id_tipo_producto = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", productos_StPats.id_tipo_producto);
            return View(productos_StPats);
        }

        // GET: Productos_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Productos_StPats productos_StPats = db.Productos_StPats.Find(id);
            if (productos_StPats == null)
            {
                return HttpNotFound();
            }
            return View(productos_StPats);
        }

        // POST: Productos_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Productos_StPats productos_StPats = db.Productos_StPats.Find(id);
            db.Productos_StPats.Remove(productos_StPats);
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
