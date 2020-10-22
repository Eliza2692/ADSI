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
        private static Regex r;

        static public bool IsValid(string pattern, string cad)
        {
            r = new Regex(pattern);
            return r.IsMatch(cad);
        }

        static public bool IsEmail(string cad)
        {
            return IsValid(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))", cad);
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
