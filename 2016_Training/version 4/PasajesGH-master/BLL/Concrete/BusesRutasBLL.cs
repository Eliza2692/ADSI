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
    public class BusesRutasBLL : IAbstract<BUSES_RUTAS, WInteger>
    {

        private PasajesBDEntities db;

        public void Add(BUSES_RUTAS obj)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    db.BUSES_RUTAS.Add(obj);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(BUSES_RUTAS obj)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public BUSES_RUTAS GetById(WInteger id)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.BUSES_RUTAS
                            where t.IdBusRuta.Equals(id.Value)
                            select t).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<BUSES_RUTAS> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(BUSES_RUTAS obj, WInteger id)
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

        public void Delete(BUSES_RUTAS obj)
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

        public IEnumerable<object> GetAll2()
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.BUSES_RUTAS
                            join hor in db.HORARIOS
                            on t.IdHorario equals hor.IdHorario
                            join rut in db.RUTAS
                            on hor.IdRuta equals rut.IdRuta
                            join ciu in db.CIUDADES
                            on rut.CiudadOrigen equals ciu.IdCiudad
                            join ciu2 in db.CIUDADES
                            on rut.CiudadDestino equals ciu2.IdCiudad
                            select new {t.IdBusRuta,t.idBus,Origen=ciu.NombreCiudad,Destino=ciu2.NombreCiudad,hor.Hora,t.FechaRuta}).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
