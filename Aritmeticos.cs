using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el primer numero:");
            float valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            float valor2 = Convert.ToInt32(Console.ReadLine());
            float suma = valor1 + valor2;
            Console.WriteLine("La suma es: " + suma);

            float resta = valor1 - valor2;
            float division = valor1 / valor2;
            float multiplicacion = valor1 * valor2;

            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La division es: " + division);
            Console.WriteLine("La multiplicacion es: " + multiplicacion);


                          

            
          
            

           






        }
    }
}
