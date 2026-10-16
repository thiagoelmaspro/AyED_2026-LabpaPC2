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

            int[] numeros = new int[cantidad];

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Dame un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Repetidos(numeros, cantidad);
        }

        static void Repetidos(int[] Numeros, int Cantidad)
        {
            int mayor = 0;
            int contador;

            for (i = 0; i < Cantidad; i++)
            {
                contador = 0;

                for (int j = 0; j < Cantidad; j++)
                {
                    if (Numeros[i] == Numeros[j])
                    {
                        contador++;
                    }
                }

                if (contador > mayor)
                {
                    mayor = contador;
                }
            }

            Console.WriteLine("Numero/s que mas se repiten:");

            for (i = 0; i < Cantidad; i++)
            {
                contador = 0;

                for (int j = 0; j < Cantidad; j++)
                {
                    if (Numeros[i] == Numeros[j])
                    {
                        contador++;
                    }
                }

                if (contador == mayor)
                {
                    bool repetido = false;

                    for (int k = 0; k < i; k++)
                    {
                        if (Numeros[i] == Numeros[k])
                        {
                            repetido = true;
                        }
                    }

                    if (repetido == false)
                    {
                        Console.WriteLine(Numeros[i]);
                    }
                }
            }

            Console.WriteLine("Cantidad de veces que se repiten: " + mayor);
        }
    }
}

