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
            int mayor = 0;
            int menor = 0;
            int suma = 0;
            int pares = 0;
            int impares = 0;

            for (i = 1; i <= Cantidad; i++)
            {
                Console.WriteLine("Dame un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }

                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                suma += numero;

                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
            Console.WriteLine("El promedio es: " + (suma / Cantidad));
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
    }
}