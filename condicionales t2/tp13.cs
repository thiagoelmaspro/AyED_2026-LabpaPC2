using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime tu genero: ");
            string genero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Decime tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            if (genero == "F" && edad >=60 || genero == "M" && edad >= 65)
            {
                Console.WriteLine("Puede iniciar el tramite jubilatorio ");

            }
           else
            {
                Console.WriteLine("Todavia no puede iniciarlo. ");
            }
        }
    }
}
