using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{

    public interface IAbstract<T, T2>
        where T : class
        where T2: class
    {

        void Add(T obj);

        void Update(T obj);

        void Delete(T obj);

        T GetById(T2 id);

        IEnumerable<T> GetAll();

        void Save(T obj, T2 id);

    }

}
