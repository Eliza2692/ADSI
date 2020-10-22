using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Model;

namespace BLL.Abstract
{
    public class Repository<T>:IAbstract<T>
        where T:class
    {

        private LibreriaBDEntities db;

        public void Add(T obj)
        {
            try
            {

                using (db = new LibreriaBDEntities())
                {
                    db.Set<T>().Add(obj);
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Update(T obj, object id)
        {
            try
            {

                using (db = new LibreriaBDEntities())
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

        public void Delete(T obj)
        {
            try
            {
                using (db = new LibreriaBDEntities())
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

        public T GetById(object id)
        {
            try
            {
                using (db = new LibreriaBDEntities())
                {

                    return db.Set<T>().Find(id);

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {

                using (db = new LibreriaBDEntities())
                {

                    return db.Set<T>().ToList();

                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Save(T obj, object id)
        {
            var x = GetById(id);

            if (x == null)
                Add(obj);
            else
                Update(obj, id);

        }

    }
}
