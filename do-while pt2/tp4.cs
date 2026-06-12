using System;

class Program
{
    static void Main()
    {
        string usuario;
        string contraseña;
        int intentos = 0;

        do
        {
            Console.Write("Usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            contraseña = Console.ReadLine();

            intentos++;

        } while ((usuario != "admin" || contraseña != "1234") && intentos < 3);

        if (usuario == "admin" && contraseña == "1234")
        {
            Console.WriteLine("Bienvenido al sistema");
        }
        else
        {
            Console.WriteLine("Cuenta bloqueada por seguridad");
        }
    }
}