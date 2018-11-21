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
    public class Tank_LFLT_VCCJ_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();

        // GET: Tank_LFLT_VCCJ_StPats
        public ActionResult Index()
        {
            var tank_LFLT_VCCJ_StPats = db.Tank_LFLT_VCCJ_StPats.Include(t => t.Estado_StPats).Include(t => t.Locations_StPats).Include(t => t.Manufactured_Stpats).Include(t => t.Productos_StPats).Include(t => t.Tipo_Producto_StPats);
            return View(tank_LFLT_VCCJ_StPats.ToList());
        }

        // GET: Tank_LFLT_VCCJ_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats = db.Tank_LFLT_VCCJ_StPats.Find(id);
            if (tank_LFLT_VCCJ_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tank_LFLT_VCCJ_StPats);
        }

        // GET: Tank_LFLT_VCCJ_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name");
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Tank_LFLT_VCCJ_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_filter_acf,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,capacity,orientation,total_area,botton_valve,racking_valve,sample_tap,thermometer_in_thermowell,thermowell_for_sensor,liftning_arm,vent,wall_thickness_bottom_thickness,replacement_inflatable_gasket")] Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Tank_LFLT_VCCJ_StPats.Add(tank_LFLT_VCCJ_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LFLT_VCCJ_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LFLT_VCCJ_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LFLT_VCCJ_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LFLT_VCCJ_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LFLT_VCCJ_StPats.id_producto_general);
            return View(tank_LFLT_VCCJ_StPats);
        }

        // GET: Tank_LFLT_VCCJ_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats = db.Tank_LFLT_VCCJ_StPats.Find(id);
            if (tank_LFLT_VCCJ_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LFLT_VCCJ_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LFLT_VCCJ_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LFLT_VCCJ_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LFLT_VCCJ_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LFLT_VCCJ_StPats.id_producto_general);
            return View(tank_LFLT_VCCJ_StPats);
        }

        // POST: Tank_LFLT_VCCJ_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_filter_acf,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,capacity,orientation,total_area,botton_valve,racking_valve,sample_tap,thermometer_in_thermowell,thermowell_for_sensor,liftning_arm,vent,wall_thickness_bottom_thickness,replacement_inflatable_gasket")] Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tank_LFLT_VCCJ_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LFLT_VCCJ_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LFLT_VCCJ_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LFLT_VCCJ_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LFLT_VCCJ_StPats.id_producto_general);
            ViewBag.id_producto_general = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LFLT_VCCJ_StPats.id_producto_general);
            return View(tank_LFLT_VCCJ_StPats);
        }

        // GET: Tank_LFLT_VCCJ_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats = db.Tank_LFLT_VCCJ_StPats.Find(id);
            if (tank_LFLT_VCCJ_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tank_LFLT_VCCJ_StPats);
        }

        // POST: Tank_LFLT_VCCJ_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tank_LFLT_VCCJ_StPats tank_LFLT_VCCJ_StPats = db.Tank_LFLT_VCCJ_StPats.Find(id);
            db.Tank_LFLT_VCCJ_StPats.Remove(tank_LFLT_VCCJ_StPats);
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
