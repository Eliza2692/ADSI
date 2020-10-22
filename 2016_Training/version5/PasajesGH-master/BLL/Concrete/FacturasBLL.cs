using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Model;
using Misc;
using System.Data.Entity;

namespace BLL.Concrete
{
    public class FacturasBLL:IAbstract<FACTURAS,WInteger>
    {
        private PasajesBDEntities db;

        public void Add(FACTURAS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.FACTURAS.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(FACTURAS obj)
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

        public FACTURAS GetById(WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.FACTURAS
                            where t.IdFactura == id.Value
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<FACTURAS> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.FACTURAS
                            select t).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(FACTURAS obj, WInteger id)
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

        public void Delete(FACTURAS obj)
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
