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
            Console.WriteLine("Ingrese un número: " );
            int numero = int.Parse(Console.ReadLine());
            

            while (numero > 0) 
            {
                Console.WriteLine("Cuenta regresiva: " + numero);
                numero--;
                

            }   



        }
    }
}
