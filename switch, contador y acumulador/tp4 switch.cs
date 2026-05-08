using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            for (int i=1 ; i<=5 ; i++)
            {
                Console.WriteLine("Ingresa un numero: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (numero > 100)
                {
                    
                    contador++;

                }
                

            }

            Console.WriteLine("Hay " + contador + " numeros mayores");

        }
    }
}
