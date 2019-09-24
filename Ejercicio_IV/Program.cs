using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCuenta = 0;
            double saldoActual, sumaTotal = 0.00;
            string estado = "";
            Console.WriteLine("Programa que lea datos de las cuentas corrientes e informe");
            while (nCuenta >= 0)
            {
                Console.Write("Ingrese el numero de cuenta: ");
                nCuenta = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el saldo actual de la cuenta: ");
                saldoActual = int.Parse(Console.ReadLine());

                if (saldoActual > 0)
                {
                    estado = "Acreedor";
                    sumaTotal += saldoActual;
                }
                else if (saldoActual < 0)
                {
                    estado = "Deudor";
                }
                else
                {
                    estado = "Nulo";
                }

                Console.WriteLine("Numero de cuenta: {0}    Estado:{1}",nCuenta,estado);
            }
            Console.ReadKey();



        }
    }
}
