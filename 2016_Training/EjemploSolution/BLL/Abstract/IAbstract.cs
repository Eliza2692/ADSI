using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAbstract<T> 
        where T:class
    {

        void Add(T obj);

        void Update(T obj, object id);

        void Delete(T obj);

        T GetById(object id);

        IEnumerable<T> GetAll();

        void Save(T obj, object id);

    }
}
