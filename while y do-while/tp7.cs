using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            int suma = 0;
            int contador = 1;

            while (contador <= 5) ;

            Console.WriteLine("Ingrese la nota del alumno: ");
            nota = int.Parse(Console.ReadLine());
            suma = suma + nota;
            contador ++;

        }
        

     
    }
}
