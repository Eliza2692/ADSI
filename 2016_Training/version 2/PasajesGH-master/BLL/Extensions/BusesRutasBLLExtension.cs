using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.Concrete;
using System.Data.Entity;

namespace BLL.Extensions
{
    public static class BusesRutasBLLExtension
    {
        private static PasajesBDEntities db;

        static public IEnumerable<object> GetAllOrigen(this BusesRutasBLL r)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.HORARIOS
                            join rut in db.RUTAS
                            on t.IdRuta equals rut.IdRuta
                            join ciu in db.CIUDADES
                            on rut.CiudadOrigen equals ciu.IdCiudad
                            group ciu by new { ciu.IdCiudad, ciu.NombreCiudad } into g
                            select new {g.Key.IdCiudad, g.Key.NombreCiudad}).ToList();                     
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static public IEnumerable<object> GetAllDestino(this BusesRutasBLL r, int IdOrigen)
        {
            try
            {
                using (db = new PasajesBDEntities())
                {
                    return (from t in db.HORARIOS
                            join rut in db.RUTAS
                            on t.IdRuta equals rut.IdRuta
                            join ciu in db.CIUDADES
                            on rut.CiudadDestino equals ciu.IdCiudad
                            where rut.CiudadOrigen==IdOrigen
                            group ciu by new { ciu.IdCiudad, ciu.NombreCiudad } into g
                            select new { g.Key.IdCiudad, g.Key.NombreCiudad }).ToList();  
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
