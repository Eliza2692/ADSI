using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IAbstract<T, T2>
        where T: class
        where T2: struct
    {

        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

        T GetById(T2 id);

        List<T> ReadAll();

        void ReWrite();

        List<T> ShowList(bool est);

    }
}
