using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Model;
using Misc;

namespace BLL.Concrete
{
    public class FacturasBLL:IAbstract<FACTURAS,WInteger>
    {
        public void Add(FACTURAS obj)
        {
            throw new NotImplementedException();
        }

        public void Update(FACTURAS obj)
        {
            throw new NotImplementedException();
        }

        public FACTURAS GetById(WInteger id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FACTURAS> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Save(FACTURAS obj, WInteger id)
        {
            throw new NotImplementedException();
        }


        public void Delete(FACTURAS obj)
        {
            throw new NotImplementedException();
        }
    }
}
