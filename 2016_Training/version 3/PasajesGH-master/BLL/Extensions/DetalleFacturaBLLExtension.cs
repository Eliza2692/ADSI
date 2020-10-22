using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.Concrete;

namespace BLL.Extensions
{
    public static class DetalleFacturaBLLExtension
    {

        private static PasajesBDEntities db;

        static public IEnumerable<object> GetAllOrigen(this DetalleFacturaBLL r, DateTime fecha)
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
                            where t.FechaRuta==fecha
                            group ciu by new { ciu.IdCiudad, ciu.NombreCiudad } into g
                            select new { g.Key.IdCiudad, g.Key.NombreCiudad }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static public IEnumerable<object> GetAllDestino(this DetalleFacturaBLL r, int idOrigen, DateTime fecha)
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
                            where rut.CiudadOrigen == idOrigen && t.FechaRuta == fecha
                            group ciu by new { ciu2.IdCiudad, ciu2.NombreCiudad } into g
                            select new { g.Key.IdCiudad, g.Key.NombreCiudad }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static public IEnumerable<object> GetAllHorario(this DetalleFacturaBLL r, int idOrigen, int idDestino, DateTime fecha)
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
                            where rut.CiudadOrigen == idOrigen && rut.CiudadDestino == idDestino && t.FechaRuta==fecha
                            group ciu by new { hor.Hora, t.IdHorario } into g
                            select new { g.Key.Hora, g.Key.IdHorario }).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
