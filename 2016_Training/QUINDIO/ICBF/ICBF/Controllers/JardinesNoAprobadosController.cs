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
    public class JardinesNoAprobadosController : Controller
    {
        private baseicbfEntities db = new baseicbfEntities();

        // GET: NinosJardin
        public ActionResult Index()
        {
            
            List<Regjardines> ls2 = new List<Regjardines>();

            List<JardinesNoAprobados> ls3 = new List<JardinesNoAprobados>();

            ls2 = (from t in db.Regjardines
                   select t).ToList();



            foreach (var item in ls2)
            {
              
               
                
                    if (item.estado.Equals("Negado"))
                    {
                        ls3.Add(new JardinesNoAprobados(item.nom_jardin));
                    }
                

                //lista.Add(new SelectListItem { Text = cont.ToString(), Value = item.nom_jardin });
                

            }

            //return Json(new SelectList(lista, "Text", "Value"), System.Web.Mvc.JsonRequestBehavior.AllowGet);

            return View(ls3);
        }


        // GET: JardinesNoAprobados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JardinesNoAprobados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JardinesNoAprobados/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JardinesNoAprobados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JardinesNoAprobados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JardinesNoAprobados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JardinesNoAprobados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
