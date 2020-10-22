using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ICBF.Models;

namespace ICBF.Controllers
{
    public class asignacionjardinsController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: asignacionjardins
        public ActionResult Index()
        {
            var asignacionjardin = db.asignacionjardin.Include(a => a.Datninos).Include(a => a.Regjardines);
            return View(asignacionjardin.ToList());
        }

        // GET: asignacionjardins/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionjardin asignacionjardin = db.asignacionjardin.Find(id);
            if (asignacionjardin == null)
            {
                return HttpNotFound();
            }
            return View(asignacionjardin);
        }

        // GET: asignacionjardins/Create
        public ActionResult Create()
        {
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape");
            ViewBag.nomjar = new SelectList(db.Regjardines, "nom_jardin", "ced");
            return View();
        }

        // POST: asignacionjardins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "niup,nomjar,fecha_asig")] asignacionjardin asignacionjardin)
        {
            if (ModelState.IsValid)
            {
                db.asignacionjardin.Add(asignacionjardin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", asignacionjardin.niup);
            ViewBag.nomjar = new SelectList(db.Regjardines, "nom_jardin", "ced", asignacionjardin.nomjar);
            return View(asignacionjardin);
        }

        // GET: asignacionjardins/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionjardin asignacionjardin = db.asignacionjardin.Find(id);
            if (asignacionjardin == null)
            {
                return HttpNotFound();
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", asignacionjardin.niup);
            ViewBag.nomjar = new SelectList(db.Regjardines, "nom_jardin", "ced", asignacionjardin.nomjar);
            return View(asignacionjardin);
        }

        // POST: asignacionjardins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "niup,nomjar,fecha_asig")] asignacionjardin asignacionjardin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asignacionjardin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", asignacionjardin.niup);
            ViewBag.nomjar = new SelectList(db.Regjardines, "nom_jardin", "ced", asignacionjardin.nomjar);
            return View(asignacionjardin);
        }

        // GET: asignacionjardins/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            asignacionjardin asignacionjardin = db.asignacionjardin.Find(id);
            if (asignacionjardin == null)
            {
                return HttpNotFound();
            }
            return View(asignacionjardin);
        }

        // POST: asignacionjardins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            asignacionjardin asignacionjardin = db.asignacionjardin.Find(id);
            db.asignacionjardin.Remove(asignacionjardin);
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
