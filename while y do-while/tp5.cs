using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave = "4321";
            string usuario;

            do
            {
                Console.WriteLine("Ingrese la clave: ");
                usuario = Console.ReadLine();

            } while (clave != usuario);

            Console.WriteLine("Acceso permitido ");
        }
    }
}
