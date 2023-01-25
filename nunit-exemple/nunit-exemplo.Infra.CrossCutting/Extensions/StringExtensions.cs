using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace nunit_exemple.Extensions
{
    public static class StringExtensions
    { 
        public static string ToNumbers(this string value)
        {
            //Validate if cnpj IsNullOrEmpty
            if (string.IsNullOrEmpty(value)) { return ""; }

            string numericPhone = new string(value.Where(char.IsDigit).ToArray());
            return numericPhone;
        }
    }
}
