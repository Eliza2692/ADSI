using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IAbstract <T> where T:class
    {

        void Add(T obj);

        void Update(T obj);

        void Delete(Object id);

        List<T> GetAll();

        T GetById(Object id);

    }
}
