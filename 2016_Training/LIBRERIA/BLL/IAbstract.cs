using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    interface IAbstract<T,T2>
        where T:class
        where T2:struct
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(T2 id);

        DataTable GetAll();

        T GetById(T2 id);

    }
}
