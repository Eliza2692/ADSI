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
    public class DatninosController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: Datninos
        public ActionResult Index()
        {
            var datninos = db.Datninos.Include(d => d.Dacudiente);
            return View(datninos.ToList());
        }

        // GET: Datninos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datninos datninos = db.Datninos.Find(id);
            if (datninos == null)
            {
                return HttpNotFound();
            }
            return View(datninos);
        }

        // GET: Datninos/Create
        public ActionResult Create()
        {
            ViewBag.ide_acu = new SelectList(db.Dacudiente, "ide_acu", "nom_ape");
            return View();
        }

        // POST: Datninos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "niup,nomape,tip_san,ciu_nac,ide_acu,fec_nac,dir,tel,eps")] Datninos datninos)
        {
            if (ModelState.IsValid)
            {
                if (DateTime.Now<datninos.fec_nac.AddYears(6))
                {
                   db.Datninos.Add(datninos);
                    db.SaveChanges();
                    return RedirectToAction("Index"); 
                }
                else
                {
                    ViewBag.ide_acu = new SelectList(db.Dacudiente, "ide_acu", "nom_ape", datninos.ide_acu);
                    return View(datninos);
                }
                
            }

            ViewBag.ide_acu = new SelectList(db.Dacudiente, "ide_acu", "nom_ape", datninos.ide_acu);
            return View(datninos);
        }

        // GET: Datninos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datninos datninos = db.Datninos.Find(id);
            if (datninos == null)
            {
                return HttpNotFound();
            }
            ViewBag.ide_acu = new SelectList(db.Dacudiente, "ide_acu", "nom_ape", datninos.ide_acu);
            return View(datninos);
        }

        // POST: Datninos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "niup,nomape,tip_san,ciu_nac,ide_acu,fec_nac,dir,tel,eps")] Datninos datninos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datninos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ide_acu = new SelectList(db.Dacudiente, "ide_acu", "nom_ape", datninos.ide_acu);
            return View(datninos);
        }

        // GET: Datninos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datninos datninos = db.Datninos.Find(id);
            if (datninos == null)
            {
                return HttpNotFound();
            }
            return View(datninos);
        }

        // POST: Datninos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Datninos datninos = db.Datninos.Find(id);
            db.Datninos.Remove(datninos);
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
