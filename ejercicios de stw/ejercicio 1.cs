using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el peso de la nave: ");
            float peso = Convert.ToInt32(Console.ReadLine());
            float descarga = peso - 5000;
            if (peso <= 5000)
            {
                Console.WriteLine("El peso: " + peso + ", Es menor a 5000, despeje. Buen viaje, Mando ");

            }
            else
            {
                Console.WriteLine("Alerta: Exceso de eso peso. Debes descargar " + descarga);
            }
            

           





















            }
    }
}
