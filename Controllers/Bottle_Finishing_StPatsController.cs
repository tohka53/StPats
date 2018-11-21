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
    public class Bottle_Finishing_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
         //private StPatsEntities db = new StPatsEntities();
        // GET: Bottle_Finishing_StPats
        public ActionResult Index()
        {
            var bottle_Finishing_StPats = db.Bottle_Finishing_StPats.Include(b => b.Estado_StPats).Include(b => b.Locations_StPats).Include(b => b.Manufactured_Stpats).Include(b => b.Productos_StPats).Include(b => b.Tipo_Producto_StPats);
            return View(bottle_Finishing_StPats.ToList());
        }

        // GET: Bottle_Finishing_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottle_Finishing_StPats bottle_Finishing_StPats = db.Bottle_Finishing_StPats.Find(id);
            if (bottle_Finishing_StPats == null)
            {
                return HttpNotFound();
            }
            return View(bottle_Finishing_StPats);
        }

        // GET: Bottle_Finishing_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Bottle_Finishing_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "C_id___bottle_finishing,id_producto_general,id_tipo_product,code_product,name_product,desctiption,price,id_location,image,manual,voltage_regulator,id_manufactured,stock,id_estado,extra_things")] Bottle_Finishing_StPats bottle_Finishing_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Bottle_Finishing_StPats.Add(bottle_Finishing_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", bottle_Finishing_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", bottle_Finishing_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", bottle_Finishing_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", bottle_Finishing_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", bottle_Finishing_StPats.id_tipo_product);
            return View(bottle_Finishing_StPats);
        }

        // GET: Bottle_Finishing_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottle_Finishing_StPats bottle_Finishing_StPats = db.Bottle_Finishing_StPats.Find(id);
            if (bottle_Finishing_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", bottle_Finishing_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", bottle_Finishing_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", bottle_Finishing_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", bottle_Finishing_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", bottle_Finishing_StPats.id_tipo_product);
            return View(bottle_Finishing_StPats);
        }

        // POST: Bottle_Finishing_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "C_id___bottle_finishing,id_producto_general,id_tipo_product,code_product,name_product,desctiption,price,id_location,image,manual,voltage_regulator,id_manufactured,stock,id_estado,extra_things")] Bottle_Finishing_StPats bottle_Finishing_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottle_Finishing_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", bottle_Finishing_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", bottle_Finishing_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", bottle_Finishing_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", bottle_Finishing_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", bottle_Finishing_StPats.id_tipo_product);
            return View(bottle_Finishing_StPats);
        }

        // GET: Bottle_Finishing_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottle_Finishing_StPats bottle_Finishing_StPats = db.Bottle_Finishing_StPats.Find(id);
            if (bottle_Finishing_StPats == null)
            {
                return HttpNotFound();
            }
            return View(bottle_Finishing_StPats);
        }

        // POST: Bottle_Finishing_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bottle_Finishing_StPats bottle_Finishing_StPats = db.Bottle_Finishing_StPats.Find(id);
            db.Bottle_Finishing_StPats.Remove(bottle_Finishing_StPats);
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
