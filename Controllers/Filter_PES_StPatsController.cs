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
    public class Filter_PES_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        // private StPatsEntities db = new StPatsEntities();
        // GET: Filter_PES_StPats
        public ActionResult Index()
        {
            var filter_PES_StPats = db.Filter_PES_StPats.Include(f => f.Estado_StPats).Include(f => f.Locations_StPats).Include(f => f.Manufactured_Stpats).Include(f => f.Productos_StPats).Include(f => f.Tipo_Producto_StPats);
            return View(filter_PES_StPats.ToList());
        }

        // GET: Filter_PES_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filter_PES_StPats filter_PES_StPats = db.Filter_PES_StPats.Find(id);
            if (filter_PES_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filter_PES_StPats);
        }

        // GET: Filter_PES_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Filter_PES_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_filter_pes,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,micron,price_only_10,price_10_30,price_only_30,price_15_30")] Filter_PES_StPats filter_PES_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Filter_PES_StPats.Add(filter_PES_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filter_PES_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filter_PES_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filter_PES_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filter_PES_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filter_PES_StPats.id_producto_general);
            return View(filter_PES_StPats);
        }

        // GET: Filter_PES_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filter_PES_StPats filter_PES_StPats = db.Filter_PES_StPats.Find(id);
            if (filter_PES_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filter_PES_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filter_PES_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filter_PES_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filter_PES_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filter_PES_StPats.id_producto_general);
            return View(filter_PES_StPats);
        }

        // POST: Filter_PES_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_filter_pes,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,micron,price_only_10,price_10_30,price_only_30,price_15_30")] Filter_PES_StPats filter_PES_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filter_PES_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", filter_PES_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", filter_PES_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", filter_PES_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", filter_PES_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", filter_PES_StPats.id_producto_general);
            return View(filter_PES_StPats);
        }

        // GET: Filter_PES_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filter_PES_StPats filter_PES_StPats = db.Filter_PES_StPats.Find(id);
            if (filter_PES_StPats == null)
            {
                return HttpNotFound();
            }
            return View(filter_PES_StPats);
        }

        // POST: Filter_PES_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filter_PES_StPats filter_PES_StPats = db.Filter_PES_StPats.Find(id);
            db.Filter_PES_StPats.Remove(filter_PES_StPats);
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
