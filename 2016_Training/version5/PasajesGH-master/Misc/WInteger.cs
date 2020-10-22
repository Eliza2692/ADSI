using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public class WInteger
    {
       private int val;

        public int Value 
        {
            get {return val;}
            set { val = value; } 
        }

        public WInteger()
        { }

        public WInteger(int v)
        {
            val = v;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
