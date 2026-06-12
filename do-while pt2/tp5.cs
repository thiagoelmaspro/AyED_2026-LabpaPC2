using System;

class Program
{
    static void Main()
    {
        string dato;
        int numero;

        int positivos = 0;
        int negativos = 0;
        int ceros = 0;

        do
        {
            Console.Write("Ingrese un número (o X para terminar): ");
            dato = Console.ReadLine();

            if (dato != "X" && dato != "x")
            {
                numero = Convert.ToInt32(dato);

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    if (numero < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }

        } while (dato != "X" && dato != "x");

        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Ceros: " + ceros);
    }
}