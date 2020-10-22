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

        

        public void Add(BUSES_RUTAS obj)
        {
            
        }

        public void Update(BUSES_RUTAS obj)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BUSES_RUTAS GetById(WInteger id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BUSES_RUTAS> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Save(BUSES_RUTAS obj, WInteger id)
        {
            throw new NotImplementedException();
        }


        public void Delete(BUSES_RUTAS obj)
        {
            throw new NotImplementedException();
        }
    }
}
