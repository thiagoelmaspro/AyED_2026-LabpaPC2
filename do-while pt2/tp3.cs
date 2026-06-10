using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double venta;
            
            double total = 0;
            double mayor = 0;

            int cantidad = 0;

            string respuesta;

            do
            {
                Console.WriteLine("Ingrese el monto de la venta: ");
                venta = double.Parse(Console.ReadLine())
                    ;

                total = total + venta;
                cantidad++;

                if (venta > mayor)
                {
                    mayor = venta;

                }
                Console.WriteLine("¿Desea ingresar otra venta?: ");
                respuesta = Console.ReadLine();


                
            } while (respuesta == "S");

            Console.WriteLine("Total recaudado: " + total);
            Console.WriteLine("Cantidad de ventas: " + cantidad);
            Console.WriteLine("Venta mas alta:: " + mayor);
        }
    }
}
