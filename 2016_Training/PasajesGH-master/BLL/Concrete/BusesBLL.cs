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
    public class BusesBLL : IAbstract<BUSES, string>
    {

        private PasajesBDEntities db;

        public void Add(BUSES obj)
        {
            try
            {
                using (db=new PasajesBDEntities())
                {
                    db.BUSES.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Update(BUSES obj)
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

        public BUSES GetById(string id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.BUSES
                            where t.IdBus.Equals(id)
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<BUSES> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.BUSES
                            select t).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public void Save(BUSES obj, string id)
        {
            var x = GetById(id);

            if (x==null)
            {
                Add(obj);
            }
            else
            {
                Update(obj);
            }
        }


        public void Delete(BUSES obj)
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
