using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Consecutivos(numero);

        }
        static void Consecutivos(int Numero )
        {
            int suma;
            for (i = 1; i < Numero; i++) 
            {
                suma = 0;
                for (int j = i; j < Numero; j++)
                {
                    suma += j;
                    
                    if ( suma == Numero)
                    {
                        Console.WriteLine("Representaciones encontradas: ");
                        for ( int k = i; k <= j; k++)
                        {
                            Console.WriteLine(k);
                        }
                    }
                }
            }
        }
    }
}
