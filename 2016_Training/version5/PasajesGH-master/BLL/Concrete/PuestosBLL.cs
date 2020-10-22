using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.Abstract;
using Misc;
using System.Data.Entity;

namespace BLL.Concrete
{
    public class PuestosBLL : IAbstract<PUESTOS, WInteger>
    {
        private PasajesBDEntities db;

        public void Add(PUESTOS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.PUESTOS.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(PUESTOS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PUESTOS GetById(WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.PUESTOS
                            where t.IdPuesto == id.Value
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<PUESTOS> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.PUESTOS
                            select t).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(PUESTOS obj, WInteger id)
        {
            var x = GetById(id);

            if (x == null)
            {
                Add(obj);
            }
            else
            {
                Update(obj);
            }

        }

        public void Delete(PUESTOS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
