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
    public class NinosEnfermosController : Controller
    {

        private baseicbfEntities db = new baseicbfEntities();

        // GET: NinosJardin
        public ActionResult Index()
        {

            List<regasistencia> ls2 = new List<regasistencia>();

            List<NinosEnfermos> ls3 = new List<NinosEnfermos>();

            ls2 = (from t in db.regasistencia
                   select t).ToList();

            foreach (var item in ls2)
            {



                if (item.estado_nino.Equals("Enfermo"))
                {
                    ls3.Add(new NinosEnfermos(item.Datninos.nomape));
                }


                //lista.Add(new SelectListItem { Text = cont.ToString(), Value = item.nom_jardin });


            }

            //return Json(new SelectList(lista, "Text", "Value"), System.Web.Mvc.JsonRequestBehavior.AllowGet);

            return View(ls3);
        }



        // GET: NinosEnfermos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NinosEnfermos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NinosEnfermos/Create
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

        // GET: NinosEnfermos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NinosEnfermos/Edit/5
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

        // GET: NinosEnfermos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NinosEnfermos/Delete/5
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
