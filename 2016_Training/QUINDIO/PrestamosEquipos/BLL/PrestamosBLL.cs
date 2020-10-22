using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL;

namespace BLL
{
    public class PrestamosBLL
    {
        private EquiposDBEntities db;

        public void Add(Prestamos obj)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    db.Prestamos.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Prestamos obj)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Prestamos obj)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Prestamos GetById(int id)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Prestamos
                            where t.ID.Equals(id)
                            select t).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        
    }
}
