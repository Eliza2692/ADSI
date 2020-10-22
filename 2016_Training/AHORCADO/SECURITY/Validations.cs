using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SECURITY
{
    public static class Validations
    {

        static private Regex r;

        static public bool IsValid(string pattern, string cad)
        {
            r = new Regex(pattern);
            return r.IsMatch(cad);
        }
        
        static public bool IsDigit(string cad)
        {
            return IsValid("[0-9]", cad);
        }

        static public bool IsText(string cad)
        {
            return IsValid(@"[a-zA-ZñÑáÁéÉíÍóÓúÚ ,.Üü]", cad);
        }

    }
}
