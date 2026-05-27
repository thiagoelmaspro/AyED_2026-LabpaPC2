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
            int opcion = 0;

            while (opcion != 3) 
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-Saludar ");
                Console.WriteLine("2-Despedirse ");
                Console.WriteLine("3-Salir ");
           
                

            Console.WriteLine("Elegi una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if ( opcion == 1)
            {
                Console.WriteLine("Hola, como estas? ");

            }       
            else if ( opcion == 2)
                {
                Console.WriteLine("Bueno amigo, nos vemos!! ");
            }

           else if (opcion == 3)
            {
                Console.WriteLine("Saliendo del programa" );

            }


            }


        }
    }
}
