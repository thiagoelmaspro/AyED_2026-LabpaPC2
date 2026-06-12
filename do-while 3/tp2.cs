using System;

class Program
{
    static void Main()
    {
        string nombre;
        string estado;
        string seguir = "S";

        int presentes = 0;
        int ausentes = 0;
        int total;

        while (seguir == "S")
        {
            Console.Write("Nombre del alumno: ");
            nombre = Console.ReadLine();

            Console.Write("Estado (P/A): ");
            estado = Console.ReadLine().ToUpper();

            if (estado == "P")
            {
                presentes++;
            }
            else
            {
                ausentes++;
            }

            Console.Write("¿Cargar otro alumno? (S/N): ");
            seguir = Console.ReadLine().ToUpper();
        }

        total = presentes + ausentes;

        double porcentaje = (double)presentes * 100 / total;

        Console.WriteLine("Presentes: " + presentes);
        Console.WriteLine("Ausentes: " + ausentes);
        Console.WriteLine("Porcentaje de presentismo: " + porcentaje + "%");
    }
} 