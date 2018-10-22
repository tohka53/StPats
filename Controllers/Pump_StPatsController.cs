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
    public class Pump_StPatsController : Controller
    {
        private StPatsDataBaseEntities1 db = new StPatsDataBaseEntities1();

        // GET: Pump_StPats
        public ActionResult Index()
        {
            var pump_StPats = db.Pump_StPats.Include(p => p.Estado_StPats).Include(p => p.Locations_StPats).Include(p => p.Manufactured_Stpats).Include(p => p.Productos_StPats).Include(p => p.Tipo_Producto_StPats);
            return View(pump_StPats.ToList());
        }

        // GET: Pump_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pump_StPats pump_StPats = db.Pump_StPats.Find(id);
            if (pump_StPats == null)
            {
                return HttpNotFound();
            }
            return View(pump_StPats);
        }

        // GET: Pump_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Pump_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_pump,id_producto_general,id_tipo_product,code_produt,name_product,description,price,image,manual,id_manufactured,id_estado,extra_things,stock,voltage_regulator,id_location")] Pump_StPats pump_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Pump_StPats.Add(pump_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", pump_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", pump_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", pump_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", pump_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", pump_StPats.id_tipo_product);
            return View(pump_StPats);
        }

        // GET: Pump_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pump_StPats pump_StPats = db.Pump_StPats.Find(id);
            if (pump_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", pump_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", pump_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", pump_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", pump_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", pump_StPats.id_tipo_product);
            return View(pump_StPats);
        }

        // POST: Pump_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_pump,id_producto_general,id_tipo_product,code_produt,name_product,description,price,image,manual,id_manufactured,id_estado,extra_things,stock,voltage_regulator,id_location")] Pump_StPats pump_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pump_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", pump_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", pump_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", pump_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", pump_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", pump_StPats.id_tipo_product);
            return View(pump_StPats);
        }

        // GET: Pump_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pump_StPats pump_StPats = db.Pump_StPats.Find(id);
            if (pump_StPats == null)
            {
                return HttpNotFound();
            }
            return View(pump_StPats);
        }

        // POST: Pump_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pump_StPats pump_StPats = db.Pump_StPats.Find(id);
            db.Pump_StPats.Remove(pump_StPats);
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
