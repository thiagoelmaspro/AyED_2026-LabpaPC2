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
            Console.WriteLine("Decime tu nombre de usurio: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Decime la clave del usuario");
            string clave = Console.ReadLine();

            if (usuario == "admin" && clave == "1234")
            {
                Console.WriteLine("Acceso concedido ");
            }
            else
                Console.WriteLine("Error de credenciales");
        }

        
    }
}
