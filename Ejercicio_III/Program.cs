using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, np = 0, nn = 0, npp = 0, nip = 0;
            Console.WriteLine("Programa que permite ingresar n numeros enteros");
            Console.Write("Ingrese la cantidad de numeros a evaluar: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Ingrese el numero {0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    np++;
                }
                if (valor < 0)
                {
                    nn++;
                }
                if (valor%2==0)
                {
                    npp++;
                }
                if (valor%2 != 0)
                {
                    nip++;
                }
            }
            Console.WriteLine("\n********************************************************");
            Console.WriteLine("Detalle de numeros ingresados: ");
            Console.WriteLine("********************************************************");
            Console.WriteLine("a) Numeros Positivos: {0}",np);
            Console.WriteLine("b) Numeros Negativos: {0}", nn);
            Console.WriteLine("c) Numeros Pares: {0}", npp);
            Console.WriteLine("d) Numeros Impares: {0}", nip);

            Console.ReadKey();
        }
    }
}
