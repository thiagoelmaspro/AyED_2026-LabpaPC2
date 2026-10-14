using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Factorizar(numero);
        }

        static void Factorizar(int Numero)
        {
            int contador = 0;
            int divisor = 2;

            Console.WriteLine("Factores primos:");

            while (Numero > 1)
            {
                if (Numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    Numero = Numero / divisor;
                    contador++;
                }
                else
                {
                    divisor++;
                }
            }

            Console.WriteLine("Cantidad de factores primos: " + contador);
        }
    }
}