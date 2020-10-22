using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Security
{
    static public class Validation
    {
        static private Regex r;

        static public bool IsValid(string pattern, string cad)
        {
            r = new Regex(pattern);
            return r.IsMatch(cad);
        }

        static public bool IsEmail(string cad)
        {
            return IsValid("^.+@+\\.[a-z]{2,3}$", cad);
        }

        static public bool IsIPv4(string cad)
        {
            return IsValid("", cad);
        }

        static public bool IsDigit(string cad)
        {
            return IsValid("[0-9]", cad);
        }

        static public bool IsText(string cad)
        {
            return IsValid("[a-zA-ZñÑáÁéÉíÍóÓúÚ]", cad);
        }
    }
}
