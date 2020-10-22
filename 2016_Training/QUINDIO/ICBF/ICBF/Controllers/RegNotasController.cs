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
    public class RegNotasController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: RegNotas
        public ActionResult Index()
        {
            var regNotas = db.RegNotas.Include(r => r.Datninos);
            return View(regNotas.ToList());
        }

        public ActionResult Index2()
        {
            var regNotas = db.RegNotas.Include(r => r.Datninos);
            return View(regNotas.ToList());
        }

        // GET: RegNotas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegNotas regNotas = db.RegNotas.Find(id);
            if (regNotas == null)
            {
                return HttpNotFound();
            }
            return View(regNotas);
        }

        // GET: RegNotas/Create
        public ActionResult Create()
        {
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape");
            return View();
        }

        // POST: RegNotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "niup,ano_escolar,nivel,nota,fec,observaciones")] RegNotas regNotas)
        {
            if (ModelState.IsValid)
            {
                db.RegNotas.Add(regNotas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regNotas.niup);
            return View(regNotas);
        }

        // GET: RegNotas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegNotas regNotas = db.RegNotas.Find(id);
            if (regNotas == null)
            {
                return HttpNotFound();
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regNotas.niup);
            return View(regNotas);
        }

        // POST: RegNotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "niup,ano_escolar,nivel,nota,fec,observaciones")] RegNotas regNotas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regNotas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.niup = new SelectList(db.Datninos, "niup", "nomape", regNotas.niup);
            return View(regNotas);
        }

        // GET: RegNotas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegNotas regNotas = db.RegNotas.Find(id);
            if (regNotas == null)
            {
                return HttpNotFound();
            }
            return View(regNotas);
        }

        // POST: RegNotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RegNotas regNotas = db.RegNotas.Find(id);
            db.RegNotas.Remove(regNotas);
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
