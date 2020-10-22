using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Abstract
{
    public interface IFormAbstract
    {
        void CleanText(bool est = false);
        
        void FillGrid();
        
        void Search(int id);
        
        void Save();
        
        void Delete(int id);
        
    }
}
