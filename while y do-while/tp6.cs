using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;

            while (contador <= numero)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("Numeros par: " + contador);

                }
                contador++;
            }
                

                
        }
    }
}
