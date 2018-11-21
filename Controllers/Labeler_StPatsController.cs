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
    public class Labeler_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        //  private StPatsEntities db = new StPatsEntities();
        // GET: Labeler_StPats
        public ActionResult Index()
        {

            var labeler_StPats = db.Labeler_StPats.Include(l => l.Estado_StPats).Include(l => l.Locations_StPats).Include(l => l.Manufactured_Stpats).Include(l => l.Productos_StPats).Include(l => l.Tipo_Producto_StPats);
            return View(labeler_StPats.ToList());
        }

        // GET: Labeler_StPats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labeler_StPats labeler_StPats = db.Labeler_StPats.Find(id);
            if (labeler_StPats == null)
            {
                return HttpNotFound();
            }
            return View(labeler_StPats);
        }

        // GET: Labeler_StPats/Create
        public ActionResult Create()
        {
            ViewBag.estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt");
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt");
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description");
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured");
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo");
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto");
            return View();
        }

        // POST: Labeler_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_labeler,id_producto_general,id_tipo_product,code_produt,name_product,description,price,id_location,image,manual,id_manufactured,estado,stock,extra_things")] Labeler_StPats labeler_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Labeler_StPats.Add(labeler_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", labeler_StPats.estado);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", labeler_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", labeler_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", labeler_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", labeler_StPats.id_tipo_product);
            return View(labeler_StPats);
        }

        // GET: Labeler_StPats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labeler_StPats labeler_StPats = db.Labeler_StPats.Find(id);
            if (labeler_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", labeler_StPats.estado);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", labeler_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", labeler_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", labeler_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", labeler_StPats.id_tipo_product);
            return View(labeler_StPats);
        }

        // POST: Labeler_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_labeler,id_producto_general,id_tipo_product,code_produt,name_product,description,price,id_location,image,manual,id_manufactured,estado,stock,extra_things")] Labeler_StPats labeler_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labeler_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", labeler_StPats.estado);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_labeler = new SelectList(db.Labeler_StPats, "id_labeler", "code_produt", labeler_StPats.id_labeler);
            ViewBag.id_location = new SelectList(db.Locations_StPats, "id_location", "description", labeler_StPats.id_location);
            ViewBag.id_manufactured = new SelectList(db.Manufactured_Stpats, "id_manufactured", "name_manufactured", labeler_StPats.id_manufactured);
            ViewBag.id_producto_general = new SelectList(db.Productos_StPats, "id_producto", "codigo", labeler_StPats.id_producto_general);
            ViewBag.id_tipo_product = new SelectList(db.Tipo_Producto_StPats, "id_tipo_producto", "descripcion_producto", labeler_StPats.id_tipo_product);
            return View(labeler_StPats);
        }

        // GET: Labeler_StPats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Labeler_StPats labeler_StPats = db.Labeler_StPats.Find(id);
            if (labeler_StPats == null)
            {
                return HttpNotFound();
            }
            return View(labeler_StPats);
        }

        // POST: Labeler_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Labeler_StPats labeler_StPats = db.Labeler_StPats.Find(id);
            db.Labeler_StPats.Remove(labeler_StPats);
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
