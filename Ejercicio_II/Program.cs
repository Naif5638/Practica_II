using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, year;
            Console.WriteLine("Programa que dado un operacio se conoce su sueldo y los años de antiguedad");
            Console.Write("Ingrese el sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese sus años de trabajo: ");
            year = double.Parse(Console.ReadLine());
            if (sueldo < 500)
            {
                if (year >= 10)
                {
                    Console.WriteLine("Su sueldo a pagar es de {0:C2}, producto de un aumento del 20%",
                        sueldo * 1.20);
                }
                else
                {
                    Console.WriteLine("Su sueldo a pagar es de {0:C2}, producto de un aumento del 20%",
                        sueldo * 1.05);
                }

            }
            else
            {
                Console.WriteLine("Su sueldo a pagar es de {0:C2}", sueldo);
            }

            Console.ReadKey();
        }
    }
}
