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
    public class DatMadrecomunitariasController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: DatMadrecomunitarias
        public ActionResult Index()
        {
            return View(db.DatMadrecomunitaria.ToList());
        }

        // GET: DatMadrecomunitarias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMadrecomunitaria datMadrecomunitaria = db.DatMadrecomunitaria.Find(id);
            if (datMadrecomunitaria == null)
            {
                return HttpNotFound();
            }
            return View(datMadrecomunitaria);
        }

        // GET: DatMadrecomunitarias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatMadrecomunitarias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cedula,nom_ape,telefono,dire,fec_nac")] DatMadrecomunitaria datMadrecomunitaria)
        {
            if (ModelState.IsValid)                        
            {
                DatMadrecomunitaria obj = db.DatMadrecomunitaria.Where(r => r.cedula == datMadrecomunitaria.cedula).SingleOrDefault();

                if (obj == null)
                {
                    db.DatMadrecomunitaria.Add(datMadrecomunitaria);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    
                    return View(datMadrecomunitaria);
                }

                
            }

            return View(datMadrecomunitaria);
        }

        // GET: DatMadrecomunitarias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMadrecomunitaria datMadrecomunitaria = db.DatMadrecomunitaria.Find(id);
            if (datMadrecomunitaria == null)
            {
                return HttpNotFound();
            }
            return View(datMadrecomunitaria);
        }

        // POST: DatMadrecomunitarias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cedula,nom_ape,telefono,dire,fec_nac")] DatMadrecomunitaria datMadrecomunitaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datMadrecomunitaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datMadrecomunitaria);
        }

        // GET: DatMadrecomunitarias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatMadrecomunitaria datMadrecomunitaria = db.DatMadrecomunitaria.Find(id);
            if (datMadrecomunitaria == null)
            {
                return HttpNotFound();
            }
            return View(datMadrecomunitaria);
        }

        // POST: DatMadrecomunitarias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DatMadrecomunitaria datMadrecomunitaria = db.DatMadrecomunitaria.Find(id);
            db.DatMadrecomunitaria.Remove(datMadrecomunitaria);
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
