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
    public class ClientesBLL:IAbstract<CLIENTES,string>
    {

        private PasajesBDEntities db;

        public void Add(CLIENTES obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.CLIENTES.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public void Update(CLIENTES obj)
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

        public CLIENTES GetById(string id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.CLIENTES 
                           where t.IdCliente.Equals(id)
                           select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<CLIENTES> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.CLIENTES
                            select t).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Save(CLIENTES obj, string id)
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


        public void Delete(CLIENTES obj)
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
