using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class EstudiantesBLL:IAbstract<Estudiantes>
    {

        private EquiposDBEntities db;

        public void Add(Estudiantes obj)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    db.Estudiantes.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Estudiantes obj)
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

        public void Delete(Estudiantes obj)
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

        public Estudiantes GetById(string id)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Estudiantes
                                where t.Codigo.Equals(id)
                                select t).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Estudiantes> GetAll()
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Estudiantes
                            select t).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Estudiantes GetById2(int id)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Estudiantes
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
