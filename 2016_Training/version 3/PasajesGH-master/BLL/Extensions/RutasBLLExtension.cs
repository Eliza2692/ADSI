using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.Concrete;
using Misc;
using System.Data.Entity;

namespace BLL.Extensions
{    
    public static class RutasBLLExtension
    {
        private static PasajesBDEntities db;

        public static IEnumerable<CIUDADES> GetAllId(this RutasBLL r ,  WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.CIUDADES
                            where !t.IdCiudad.Equals(id.Value)
                            select t).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static RUTAS GetByCity(this RutasBLL r, int origen, int destino)
        {

            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.RUTAS
                            where t.CiudadOrigen.Equals(origen) && t.CiudadDestino.Equals(destino)
                            select t).SingleOrDefault();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void AddHorario(this RutasBLL r, HORARIOS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.HORARIOS.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateHorario(this RutasBLL r, HORARIOS obj)
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

        public static HORARIOS GetById(this RutasBLL r, int id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.HORARIOS
                            where t.IdHorario == id
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Save(this RutasBLL r, HORARIOS obj, int id)
        {
            var x = GetById(r, id);

            if (x == null)
            {
                AddHorario(r, obj);
            }
            else
            {
                UpdateHorario(r, obj);
            }


        }
        
        public static void Delete(this RutasBLL r, HORARIOS obj)
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
