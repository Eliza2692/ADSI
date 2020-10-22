using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.Abstract;
using System.Data.Entity;
using Misc;

namespace BLL.Concrete
{
    public class CiudadesBLL:IAbstract<CIUDADES,WInteger>
    {

        private PasajesBDEntities db;

        public void Add(CIUDADES obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.CIUDADES.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Update(CIUDADES obj)
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

        public void Delete(CIUDADES obj)
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

        public CIUDADES GetById(WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                   return (from t in db.CIUDADES
                            where t.IdCiudad.Equals(id.Value)
                            select t).SingleOrDefault();

                    //return db.CIUDADES.Where(x => x.IdCiudad.Equals(id)).SingleOrDefault();
                    
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<CIUDADES> GetAll()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.CIUDADES
                            select t).ToList();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void Save(CIUDADES obj, WInteger id)
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

    }
}
