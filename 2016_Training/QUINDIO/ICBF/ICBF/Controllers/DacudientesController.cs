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
    public class DacudientesController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: Dacudientes
        public ActionResult Index()
        {
            return View(db.Dacudiente.ToList());
        }

        // GET: Dacudientes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dacudiente dacudiente = db.Dacudiente.Find(id);
            if (dacudiente == null)
            {
                return HttpNotFound();
            }
            return View(dacudiente);
        }

        // GET: Dacudientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dacudientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ide_acu,nom_ape,telefono,dire,correo,celular")] Dacudiente dacudiente)
        {
            if (ModelState.IsValid)
            {
                db.Dacudiente.Add(dacudiente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dacudiente);
        }

        // GET: Dacudientes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dacudiente dacudiente = db.Dacudiente.Find(id);
            if (dacudiente == null)
            {
                return HttpNotFound();
            }
            return View(dacudiente);
        }

        // POST: Dacudientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ide_acu,nom_ape,telefono,dire,correo,celular")] Dacudiente dacudiente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dacudiente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dacudiente);
        }

        // GET: Dacudientes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dacudiente dacudiente = db.Dacudiente.Find(id);
            if (dacudiente == null)
            {
                return HttpNotFound();
            }
            return View(dacudiente);
        }

        // POST: Dacudientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Dacudiente dacudiente = db.Dacudiente.Find(id);
            db.Dacudiente.Remove(dacudiente);
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
