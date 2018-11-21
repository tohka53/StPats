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
    public class Shopping_Cart_Detalle_StPatsController : Controller
    {
        private StPatsWEB_dbEntities db = new StPatsWEB_dbEntities();
        // private StPatsEntities db = new StPatsEntities();
        // GET: Shopping_Cart_Detalle_StPats
        public ActionResult Index()
        {
            var shopping_Cart_Detalle_StPats = db.Shopping_Cart_Detalle_StPats.Include(s => s.Estado_StPats).Include(s => s.Lista_Productos_StPats).Include(s => s.Shopping_Cart_StPats);
            return View(shopping_Cart_Detalle_StPats.ToList());
        }

        // GET: Shopping_Cart_Detalle_StPats/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats = db.Shopping_Cart_Detalle_StPats.Find(id);
            if (shopping_Cart_Detalle_StPats == null)
            {
                return HttpNotFound();
            }
            return View(shopping_Cart_Detalle_StPats);
        }

        // GET: Shopping_Cart_Detalle_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            ViewBag.id_lista_producto = new SelectList(db.Lista_Productos_StPats, "id_lista_producto", "id_lista_producto");
            ViewBag.id_shoppingcart = new SelectList(db.Shopping_Cart_StPats, "id_shoppingcart", "id_shoppingcart");
            return View();
        }

        // POST: Shopping_Cart_Detalle_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_shoppingcart_detalle,id_shoppingcart,id_lista_producto,id_estado")] Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Shopping_Cart_Detalle_StPats.Add(shopping_Cart_Detalle_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", shopping_Cart_Detalle_StPats.id_estado);
            ViewBag.id_lista_producto = new SelectList(db.Lista_Productos_StPats, "id_lista_producto", "id_lista_producto", shopping_Cart_Detalle_StPats.id_lista_producto);
            ViewBag.id_shoppingcart = new SelectList(db.Shopping_Cart_StPats, "id_shoppingcart", "id_shoppingcart", shopping_Cart_Detalle_StPats.id_shoppingcart);
            return View(shopping_Cart_Detalle_StPats);
        }

        // GET: Shopping_Cart_Detalle_StPats/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats = db.Shopping_Cart_Detalle_StPats.Find(id);
            if (shopping_Cart_Detalle_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", shopping_Cart_Detalle_StPats.id_estado);
            ViewBag.id_lista_producto = new SelectList(db.Lista_Productos_StPats, "id_lista_producto", "id_lista_producto", shopping_Cart_Detalle_StPats.id_lista_producto);
            ViewBag.id_shoppingcart = new SelectList(db.Shopping_Cart_StPats, "id_shoppingcart", "id_shoppingcart", shopping_Cart_Detalle_StPats.id_shoppingcart);
            return View(shopping_Cart_Detalle_StPats);
        }

        // POST: Shopping_Cart_Detalle_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_shoppingcart_detalle,id_shoppingcart,id_lista_producto,id_estado")] Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopping_Cart_Detalle_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion", shopping_Cart_Detalle_StPats.id_estado);
            ViewBag.id_lista_producto = new SelectList(db.Lista_Productos_StPats, "id_lista_producto", "id_lista_producto", shopping_Cart_Detalle_StPats.id_lista_producto);
            ViewBag.id_shoppingcart = new SelectList(db.Shopping_Cart_StPats, "id_shoppingcart", "id_shoppingcart", shopping_Cart_Detalle_StPats.id_shoppingcart);
            return View(shopping_Cart_Detalle_StPats);
        }

        // GET: Shopping_Cart_Detalle_StPats/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats = db.Shopping_Cart_Detalle_StPats.Find(id);
            if (shopping_Cart_Detalle_StPats == null)
            {
                return HttpNotFound();
            }
            return View(shopping_Cart_Detalle_StPats);
        }

        // POST: Shopping_Cart_Detalle_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Shopping_Cart_Detalle_StPats shopping_Cart_Detalle_StPats = db.Shopping_Cart_Detalle_StPats.Find(id);
            db.Shopping_Cart_Detalle_StPats.Remove(shopping_Cart_Detalle_StPats);
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
