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
    public class Tank_LCTTCJ_VC_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();

        // GET: Tank_LCTTCJ_VC_StPats
        public ActionResult Index()
        {
            var tank_LCTTCJ_VC_StPats = db.Tank_LCTTCJ_VC_StPats.Include(t => t.Estado_StPats).Include(t => t.Locations_StPats).Include(t => t.Manufactured_Stpats).Include(t => t.Productos_StPats).Include(t => t.Tipo_Producto_StPats);
            return View(tank_LCTTCJ_VC_StPats.ToList());
        }

        // GET: Tank_LCTTCJ_VC_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats = db.Tank_LCTTCJ_VC_StPats.Find(id);
            if (tank_LCTTCJ_VC_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tank_LCTTCJ_VC_StPats);
        }

        // GET: Tank_LCTTCJ_VC_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name");
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Tank_LCTTCJ_VC_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_filter_acf,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,capacity,number_of_jackets,orientation,total_area,botton_valve,racking_valve,pump_over,vent,ladder_support,sample_tap,thermometer_in_thermowell,thermowell_for_sensor,level_gange,top_hatch,wall_thickness_bottom_thickness")] Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Tank_LCTTCJ_VC_StPats.Add(tank_LCTTCJ_VC_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LCTTCJ_VC_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LCTTCJ_VC_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LCTTCJ_VC_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LCTTCJ_VC_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LCTTCJ_VC_StPats.id_tipo_product);
            return View(tank_LCTTCJ_VC_StPats);
        }

        // GET: Tank_LCTTCJ_VC_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats = db.Tank_LCTTCJ_VC_StPats.Find(id);
            if (tank_LCTTCJ_VC_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LCTTCJ_VC_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LCTTCJ_VC_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LCTTCJ_VC_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LCTTCJ_VC_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LCTTCJ_VC_StPats.id_tipo_product);
            return View(tank_LCTTCJ_VC_StPats);
        }

        // POST: Tank_LCTTCJ_VC_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_filter_acf,id_producto_general,id_tipo_product,code_produt,name_product,description,id_location,id_manufactured,stock,id_estado,extra_things,capacity,number_of_jackets,orientation,total_area,botton_valve,racking_valve,pump_over,vent,ladder_support,sample_tap,thermometer_in_thermowell,thermowell_for_sensor,level_gange,top_hatch,wall_thickness_bottom_thickness")] Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tank_LCTTCJ_VC_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", tank_LCTTCJ_VC_StPats.id_estado);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", tank_LCTTCJ_VC_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", tank_LCTTCJ_VC_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "product_name", tank_LCTTCJ_VC_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", tank_LCTTCJ_VC_StPats.id_tipo_product);
            return View(tank_LCTTCJ_VC_StPats);
        }

        // GET: Tank_LCTTCJ_VC_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats = db.Tank_LCTTCJ_VC_StPats.Find(id);
            if (tank_LCTTCJ_VC_StPats == null)
            {
                return HttpNotFound();
            }
            return View(tank_LCTTCJ_VC_StPats);
        }

        // POST: Tank_LCTTCJ_VC_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tank_LCTTCJ_VC_StPats tank_LCTTCJ_VC_StPats = db.Tank_LCTTCJ_VC_StPats.Find(id);
            db.Tank_LCTTCJ_VC_StPats.Remove(tank_LCTTCJ_VC_StPats);
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
