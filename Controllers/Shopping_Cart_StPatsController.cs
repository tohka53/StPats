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
    public class Shopping_Cart_StPatsController : Controller
    {
        private StPatsDataBaseEntities1 db = new StPatsDataBaseEntities1();

        // GET: Shopping_Cart_StPats
        public ActionResult Index()
        {
            var shopping_Cart_StPats = db.Shopping_Cart_StPats.Include(s => s.Estado_StPats);
            return View(shopping_Cart_StPats.ToList());
        }

        // GET: Shopping_Cart_StPats/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_StPats shopping_Cart_StPats = db.Shopping_Cart_StPats.Find(id);
            if (shopping_Cart_StPats == null)
            {
                return HttpNotFound();
            }
            return View(shopping_Cart_StPats);
        }

        // GET: Shopping_Cart_StPats/Create
        public ActionResult Create()
        {
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            return View();
        }

        // POST: Shopping_Cart_StPats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_shoppingcart,id_cliente,date,id_estado,monto_sin_taxes,taxes,monto_total")] Shopping_Cart_StPats shopping_Cart_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Shopping_Cart_StPats.Add(shopping_Cart_StPats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            return View(shopping_Cart_StPats);
        }

        // GET: Shopping_Cart_StPats/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_StPats shopping_Cart_StPats = db.Shopping_Cart_StPats.Find(id);
            if (shopping_Cart_StPats == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            return View(shopping_Cart_StPats);
        }

        // POST: Shopping_Cart_StPats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_shoppingcart,id_cliente,date,id_estado,monto_sin_taxes,taxes,monto_total")] Shopping_Cart_StPats shopping_Cart_StPats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopping_Cart_StPats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estado = new SelectList(db.Estado_StPats, "id_estado", "descripcion");
            return View(shopping_Cart_StPats);
        }

        // GET: Shopping_Cart_StPats/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shopping_Cart_StPats shopping_Cart_StPats = db.Shopping_Cart_StPats.Find(id);
            if (shopping_Cart_StPats == null)
            {
                return HttpNotFound();
            }
            return View(shopping_Cart_StPats);
        }

        // POST: Shopping_Cart_StPats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Shopping_Cart_StPats shopping_Cart_StPats = db.Shopping_Cart_StPats.Find(id);
            db.Shopping_Cart_StPats.Remove(shopping_Cart_StPats);
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
