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

            SegundoMayor(cantidad);
        }

        static void SegundoMayor(int Cantidad)
        {
            int numero;
            int mayor = 0;
            int segundo = 0;
            int cantidadMayor = 0;

            for (i = 1; i <= Cantidad; i++)
            {
                Console.WriteLine("Dame un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        segundo = mayor;
                        mayor = numero;
                    }
                    else if (numero < mayor && numero > segundo)
                    {
                        segundo = numero;
                    }
                }
            }

            for (i = 1; i <= Cantidad; i++)
            {
                // Se utiliza para mantener la estructura simple del ejercicio
            }

            if (segundo == mayor)
            {
                Console.WriteLine("No existe un segundo numero diferente");
            }
            else
            {
                Console.WriteLine("El segundo mayor es: " + segundo);
            }
        }
    }
}