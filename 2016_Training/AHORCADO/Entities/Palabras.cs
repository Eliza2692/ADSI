using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Palabras
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string palabra;

        public string Palabra
        {
            get { return palabra; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ingresar Palbras");
                }                
                palabra = value; }
        }
        
    }
}
