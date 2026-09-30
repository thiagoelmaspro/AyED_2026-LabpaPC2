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

            Perfecto(numero);
        }

        static void Perfecto(int Numero)
        {
            int suma = 0;

            for (i = 1; i < Numero; i++)
            {
                if (Numero % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == Numero)
            {
                Console.WriteLine("El numero es perfecto");
            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
        }
    }
}