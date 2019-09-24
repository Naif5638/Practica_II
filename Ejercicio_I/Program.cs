using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Programa que imprime los multiplos de 3 del 1 al 200");
            while ( i  <= 200)
            {
                
                if (i % 3 == 0) 
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
