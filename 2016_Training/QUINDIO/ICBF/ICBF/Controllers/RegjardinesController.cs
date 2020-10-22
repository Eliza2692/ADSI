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
    public class RegjardinesController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: Regjardines
        public ActionResult Index()
        {
            var regjardines = db.Regjardines.Include(r => r.DatMadrecomunitaria);
            return View(regjardines.ToList());
        }

        // GET: Regjardines/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regjardines regjardines = db.Regjardines.Find(id);
            if (regjardines == null)
            {
                return HttpNotFound();
            }
            return View(regjardines);
        }

        // GET: Regjardines/Create
        public ActionResult Create()
        {
            ViewBag.ced = new SelectList(db.DatMadrecomunitaria, "cedula", "nom_ape");
            return View();
        }

        // POST: Regjardines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ced,nom_jardin,dire,estado")] Regjardines regjardines)
        {
            if (ModelState.IsValid)
            {
                regjardines.nom_jardin = regjardines.nom_jardin.ToUpper();

                Regjardines obj = db.Regjardines.Where(r => r.nom_jardin == regjardines.nom_jardin).SingleOrDefault();

                if (obj == null)
                {

                    db.Regjardines.Add(regjardines);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(regjardines);
                }


                
            }

            ViewBag.ced = new SelectList(db.DatMadrecomunitaria, "cedula", "nom_ape", regjardines.ced);
            return View(regjardines);
        }

        // GET: Regjardines/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regjardines regjardines = db.Regjardines.Find(id);
            if (regjardines == null)
            {
                return HttpNotFound();
            }
            ViewBag.ced = new SelectList(db.DatMadrecomunitaria, "cedula", "nom_ape", regjardines.ced);
            return View(regjardines);
        }

        // POST: Regjardines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ced,nom_jardin,dire,estado")] Regjardines regjardines)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regjardines).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ced = new SelectList(db.DatMadrecomunitaria, "cedula", "nom_ape", regjardines.ced);
            return View(regjardines);
        }

        // GET: Regjardines/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regjardines regjardines = db.Regjardines.Find(id);
            if (regjardines == null)
            {
                return HttpNotFound();
            }
            return View(regjardines);
        }

        // POST: Regjardines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Regjardines regjardines = db.Regjardines.Find(id);
            db.Regjardines.Remove(regjardines);
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

        public ActionResult MostrarMadres()
        {

            List<SelectListItem> ls = new List<SelectListItem>();

            List<DatMadrecomunitaria> lista = new List<DatMadrecomunitaria>();
            List<DatMadrecomunitaria> listaTodasMadres = new List<DatMadrecomunitaria>();
            


            lista = (from t in db.DatMadrecomunitaria
                     join t2 in db.Regjardines                     
                         on t.cedula equals t2.ced
                         select t).ToList();

            listaTodasMadres = (from t in db.DatMadrecomunitaria
                         select t).ToList();



            foreach (var item in lista)
            {
                listaTodasMadres.Remove(item);
            }

            foreach (var item in listaTodasMadres)
            {
                ls.Add(new SelectListItem { Text = item.nom_ape, Value = item.nom_ape});
            }
            
            return Json(new SelectList(ls,"Text", "Value"));

        }

        /*
         
          <script type="text/javascript">

        $(document).ready(function () {

            $("#ced").empty();

            $.ajax({

                dataType: 'json',
                url: '@Url.Action("MostrarMadres")',
                type: 'POST',
                success : function(madres) 
                {
                    $.each(madres, function (i, m) {
                        $("ced").append('<option value = "' + m.cedula + '">'+m.nom_ape+'</option');
                    });
                }

            })


        });

    </script>
         */

    }
}
