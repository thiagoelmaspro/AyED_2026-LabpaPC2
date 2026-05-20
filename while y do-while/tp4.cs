using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            
            while (contador <= 12)
            {
                Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
                contador++;
            }
        }
    }
}
