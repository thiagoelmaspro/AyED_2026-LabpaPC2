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
            Console.WriteLine("Cuantos numeros vas a ingresar: ");
            int cantidad = int.Parse(Console.ReadLine());

            Calcular(cantidad);
        }

        static void Calcular(int Cantidad)
        {
            int numero;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;

            for (i = 1; i <= Cantidad; i++)
            {
                Console.WriteLine("Dame un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                    sumaPositivos += numero;
                }
                else if (numero < 0)
                {
                    negativos++;
                    sumaNegativos += numero;
                }
                else
                {
                    ceros++;
                }
            }

            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);

            if (positivos > 0)
            {
                Console.WriteLine("Promedio positivos: " + (sumaPositivos / positivos));
            }

            if (negativos > 0)
            {
                Console.WriteLine("Promedio negativos: " + (sumaNegativos / negativos));
            }
        }
    }
}