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
    public class Filling_Machine_StPatsController : Controller
    {
        private StPatsDataBaseEntities1 db = new StPatsDataBaseEntities1();

        // GET: Filling_Machine_StPats
        public ActionResult Index()
        {
            var filling_Machine_StPats = db.Filling_Machine_StPats.Include(f => f.Estado_StPats).Include(f => f.Locations_StPats).Include(f => f.Manufactured_Stpats).Include(f => f.Productos_StPats).Include(f => f.Tipo_Producto_StPats);
            return View(filling_Machine_StPats.ToList());
        }

        // GET: Filling_Machine_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filling_Machine_StPats filling_Machine_StPats = db.Filling_Machine_StPats.Find(id);
            if (filling_Machine_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filling_Machine_StPats);
        }

        // GET: Filling_Machine_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Filling_Machine_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_filling_machine,id_producto_general,id_tipo_product,code_produt,name_product,description,price,id_location,image,manual,voltage_regulator,id_manufactured,regulador,stock,id_estado,extra_things")] Filling_Machine_StPats filling_Machine_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Filling_Machine_StPats.Add(filling_Machine_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filling_Machine_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filling_Machine_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filling_Machine_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filling_Machine_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filling_Machine_StPats.id_tipo_product);
            return View(filling_Machine_StPats);
        }

        // GET: Filling_Machine_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filling_Machine_StPats filling_Machine_StPats = db.Filling_Machine_StPats.Find(id);
            if (filling_Machine_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filling_Machine_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filling_Machine_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filling_Machine_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filling_Machine_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filling_Machine_StPats.id_tipo_product);
            return View(filling_Machine_StPats);
        }

        // POST: Filling_Machine_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_filling_machine,id_producto_general,id_tipo_product,code_produt,name_product,description,price,id_location,image,manual,voltage_regulator,id_manufactured,regulador,stock,id_estado,extra_things")] Filling_Machine_StPats filling_Machine_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filling_Machine_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filling_Machine_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filling_Machine_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filling_Machine_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filling_Machine_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filling_Machine_StPats.id_tipo_product);
            return View(filling_Machine_StPats);
        }

        // GET: Filling_Machine_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filling_Machine_StPats filling_Machine_StPats = db.Filling_Machine_StPats.Find(id);
            if (filling_Machine_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filling_Machine_StPats);
        }

        // POST: Filling_Machine_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filling_Machine_StPats filling_Machine_StPats = db.Filling_Machine_StPats.Find(id);
            db.Filling_Machine_StPats.Remove(filling_Machine_StPats);
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
