using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase20202c 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Sumando numeros***");
            Console.Write("Ingrese un numero: ");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            Console.Write("Ingrese otro numero: ");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            Console.Write("La suma es: " + num1 + num2);
            Console.ReadKey();
        }
    }
}
