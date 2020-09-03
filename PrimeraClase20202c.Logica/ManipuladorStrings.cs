using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase20202c.Logica
{
    public class ManipuladorStrings
    {
        public static string ConvertirMayusculas(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input.ToUpper();
            }
            return input;
        }
    }
}
