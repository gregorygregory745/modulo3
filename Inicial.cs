using System;

class Inicial
{
    static void Main()
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        if (!string.IsNullOrEmpty(nombre))
        {
            char inicial = nombre[0];
            Console.WriteLine("Tu inicial es: " + inicial);
        }
        else
        {
            Console.WriteLine("No ingresaste un nombre.");
        }
    }
}
