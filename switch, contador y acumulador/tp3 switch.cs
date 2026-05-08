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
            int ahorroacumulado = 0;
            int ahorro = 0;
           
            for (int i=1 ; i <=4 ; i++ )
            {
                Console.WriteLine("Ingrese el ahorro de la semana N° " + i + ":");
                ahorro = int.Parse(Console.ReadLine());

                ahorroacumulado = ahorroacumulado + ahorro;

                Console.WriteLine("El dinero acumulado del mes es de " + ahorroacumulado);
            }
            
           
        
        }
    }
}
