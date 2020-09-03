using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase20202c.Logica
{
    public class Calculadora
    {
        /// <summary>
        /// Convierte los parametros string a entero y devuelve la suma
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="input3"></param>
        /// <returns></returns>
        public static int Sumar(string input1, string input2, string input3 = "0")
        {
            int num1 = Convert.ToInt32(input1);

            //tryparse es el unico que no tira excepcion en caso de que el string sea invalido
            bool valido = int.TryParse(input3, out int num3);
            
            num3 = 10 * num1;
            int num2 = Convert.ToInt32(input2);

            return num1 + num2 + num3;
        }
    }
}
