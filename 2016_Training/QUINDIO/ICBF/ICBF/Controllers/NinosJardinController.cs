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
    public class NinosJardinController : Controller
    {

        private baseicbfEntities db = new baseicbfEntities();

        // GET: NinosJardin
        public ActionResult Index()
        {
            List<asignacionjardin> ls = new List<asignacionjardin>();
            List<Regjardines> ls2 = new List<Regjardines>();


            List<SelectListItem> lista = new List<SelectListItem>();
            List<NinosJardin> lsMostrar = new List<NinosJardin>();

            ls = (from t in db.asignacionjardin
                  select t).ToList();

            ls2 = (from t in db.Regjardines
                   select t).ToList();

            foreach (var item in ls2)
            {
                int cont = 0;

                foreach (var item2 in ls)
                {
                    if (item.nom_jardin == item2.nomjar)
                    {
                        cont++;
                    }
                }

                //lista.Add(new SelectListItem { Text = cont.ToString(), Value = item.nom_jardin });
                lsMostrar.Add(new NinosJardin(item.nom_jardin, cont));

            }

            //return Json(new SelectList(lista, "Text", "Value"), System.Web.Mvc.JsonRequestBehavior.AllowGet);

            return View(lsMostrar);
        }

        // GET: NinosJardin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NinosJardin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NinosJardin/Create
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

        // GET: NinosJardin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NinosJardin/Edit/5
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

        // GET: NinosJardin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NinosJardin/Delete/5
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
