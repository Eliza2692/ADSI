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
    public class regasistenciasController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: regasistencias
        public ActionResult Index()
        {
            var regasistencia = db.regasistencia.Include(r => r.Datninos);
            return View(regasistencia.ToList());
        }

        // GET: regasistencias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regasistencia regasistencia = db.regasistencia.Find(id);
            if (regasistencia == null)
            {
                return HttpNotFound();
            }
            return View(regasistencia);
        }

        // GET: regasistencias/Create
        public ActionResult Create()
        {
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape");
            return View();
        }

        // POST: regasistencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "niup,fecha,estado_nino")] regasistencia regasistencia)
        {
            if (ModelState.IsValid)
            {
                db.regasistencia.Add(regasistencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regasistencia.niup);
            return View(regasistencia);
        }

        // GET: regasistencias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regasistencia regasistencia = db.regasistencia.Find(id);
            if (regasistencia == null)
            {
                return HttpNotFound();
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regasistencia.niup);
            return View(regasistencia);
        }

        // POST: regasistencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "niup,fecha,estado_nino")] regasistencia regasistencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regasistencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regasistencia.niup);
            return View(regasistencia);
        }

        // GET: regasistencias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regasistencia regasistencia = db.regasistencia.Find(id);
            if (regasistencia == null)
            {
                return HttpNotFound();
            }
            return View(regasistencia);
        }

        // POST: regasistencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            regasistencia regasistencia = db.regasistencia.Find(id);
            db.regasistencia.Remove(regasistencia);
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
