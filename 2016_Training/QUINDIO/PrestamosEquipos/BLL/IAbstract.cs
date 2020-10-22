using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IAbstract<T>
        where T : class
    {

        void Add(T obj);

        void Update(T obj);

        void Delete(T obj);

        T GetById(string id);

        IEnumerable<T> GetAll();

    }
}
