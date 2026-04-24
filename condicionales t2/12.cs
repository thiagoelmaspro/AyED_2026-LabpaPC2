using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decime el peso: ");
            Double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Decime la altura: ");
            Double altura = Convert.ToDouble(Console.ReadLine());
            Double IMC = peso / (altura * altura);

            if( IMC > 25)
            {
                Console.WriteLine("Sobrepeso ");

                
            }
           else
            {
                Console.WriteLine("Rango normal");
            }
        }
    }
}
