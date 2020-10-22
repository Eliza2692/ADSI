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
    public class ReportesController : Controller
    {

        private baseicbfEntities db = new baseicbfEntities();

        // GET: Reportes
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult NinosJardin()
        {
            List<asignacionjardin> ls = new List<asignacionjardin>();
            List<Regjardines> ls2 = new List<Regjardines>();


            List<SelectListItem> lista = new List<SelectListItem>();
            List<object> lsMostrar = new List<object>();

            ls = (from t in db.asignacionjardin
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

                lista.Add(new SelectListItem { Text = cont.ToString(), Value = item.nom_jardin });

            }

            return Json(new SelectList(lista, "Text", "Value"), System.Web.Mvc.JsonRequestBehavior.AllowGet);

        }
    }
}