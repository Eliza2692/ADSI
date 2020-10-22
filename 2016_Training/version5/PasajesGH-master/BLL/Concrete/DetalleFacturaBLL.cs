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
    public class DetalleFacturaBLL : IAbstract<DETALLE_FACTURA, WInteger>
    {
        private PasajesBDEntities db;

        public void Add(DETALLE_FACTURA obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.DETALLE_FACTURA.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(DETALLE_FACTURA obj)
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

        public DETALLE_FACTURA GetById(WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.DETALLE_FACTURA
                            where t.IdDetalleFactura == id.Value
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<DETALLE_FACTURA> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.DETALLE_FACTURA
                            select t).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(DETALLE_FACTURA obj, WInteger id)
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

        public void Delete(DETALLE_FACTURA obj)
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
