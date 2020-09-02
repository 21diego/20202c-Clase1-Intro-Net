using PrimeraClase20202c.Logica;
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

            Console.Write("Ingrese otro numero: ");
            string input2 = Console.ReadLine();

            int resultado = Calculadora.Sumar(input1, input2);

            Console.Write("La suma es: " + resultado);
            Console.ReadKey();
        }
    }
}
