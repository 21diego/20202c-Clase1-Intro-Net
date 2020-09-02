using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase20202c
{
    class Calculadora
    {
        public static int Sumar(string input1, string input2)
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            return num1 + num2;
        }
    }
}
