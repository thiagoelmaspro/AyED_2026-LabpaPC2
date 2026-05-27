using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int resultado = 0;
            int contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            b = int.Parse(Console.ReadLine());



            while (contador < b)
            {
                
                resultado = resultado + a;
                contador = contador + 1;
                
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
