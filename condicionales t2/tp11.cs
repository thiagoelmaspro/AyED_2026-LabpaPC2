using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Decime otro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Decime el ultimo numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("El triangulo es Equilatero ");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Es un triangulo Isóceles");
            }
            else if (num1 == num3)
            {
                Console.WriteLine("Es un triangulo Isóceles");
            }
            else if (num2 == num1)
            {
                Console.WriteLine("Es un triangulo Isóceles");

            }
            else if (num3 == num2)
            {
                Console.WriteLine("Es un triangulo Isóceles");
            }
            else
            {
                    Console.WriteLine("Es Escaleno");
            }

             
        }
    }
}
