using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Hola Como estas?: ");
            Console.WriteLine("Cuantos años tenes?: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Bienvenido al club de pelea ");

            } 
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto ");

            }   





        }
    }
}
