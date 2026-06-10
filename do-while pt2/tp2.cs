using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = 42;
            int numero;
            int intentos = 0;

            while (intentos < 5)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                intentos++;

                if ( numero == secreto )
                {
                    Console.WriteLine("¡¡GANASTEE!! ");
                    Console.WriteLine("Intentos usados: " + intentos);

                }
              else if ( numero < secreto)
                {
                    Console.WriteLine("El numero es mayor ");
                }
                else
                {
                    Console.WriteLine("El numero es menor");
                }
                
            }
        }
    }
}
