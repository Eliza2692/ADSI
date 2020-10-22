using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DAL.Model;

namespace BLL.Abstract
{
    public class Repository<T>:IAbstract<T>
            where T:class
    {
        private LibreriaBDEntities bd;

        public void Add(T obj)
        {
            try
            {
                using (bd = new LibreriaBDEntities())
                {
                    bd.Set<T>().Add(obj);
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T obj, object id)
        {
            try
            {

                using (bd = new LibreriaBDEntities())
                {
                    
                    bd.Entry(obj).State = EntityState.Modified;
                    bd.SaveChanges();

                    //var x = bd.Set<T>().Find(id);
                    //if (x != null)
                    //{
                    //    bd.Entry(x).CurrentValues.SetValues(obj);
                    //    bd.SaveChanges();
                    //}
                }
            }
            catch( DbUpdateException ex2)
            {
                throw ex2;
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
                using (bd = new LibreriaBDEntities())
                {
                    //var x = bd.Set<T>().Find(id);
                    //if (x != null)
                    //{
                    //    bd.Set<T>().Remove(x);
                    //    bd.SaveChanges();
                    //}

                    bd.Entry(obj).State = EntityState.Deleted;
                    bd.SaveChanges();

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

                using (bd = new LibreriaBDEntities())
                { return bd.Set<T>().Find(id); }
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
                using (bd = new LibreriaBDEntities())
                {
                    return bd.Set<T>().ToList();
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
            if (x==null)
            {
                Add(obj);
            }
            else
            {
                Update(obj, id);
            }
        }
    }
}
