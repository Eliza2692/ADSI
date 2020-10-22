using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class DispositivosBLL:IAbstract<Dispositivos>
    {
        private EquiposDBEntities db;

        public void Add(Dispositivos obj)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    db.Dispositivos.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Dispositivos obj)
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

        public void Delete(Dispositivos obj)
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

        public Dispositivos GetById(string id)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Dispositivos
                            where t.Codigo.Equals(id)
                            select t).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Dispositivos GetById2(int id)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Dispositivos
                            where t.ID.Equals(id)
                            select t).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Dispositivos> GetAll()
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Dispositivos
                            select t).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public IEnumerable<Dispositivos> GetByIdDis(string categoria)
        {
            try
            {
                using (db = new EquiposDBEntities())
                {
                    return (from t in db.Dispositivos
                            where t.TipoDispositivo.Equals(categoria)
                            where t.EstadoInventario.Equals("INVENTARIO")
                            where t.Estado.Equals("Bueno")
                            select t).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
