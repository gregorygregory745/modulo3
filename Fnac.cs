using System;

class Fnac
{
    static void Main()
    {
        Console.WriteLine("Ingresa tu fecha:");
        string fechaNacimientoStr = Console.ReadLine();

        try
        {
            DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dia/mes/año", null);
            DayOfWeek diaDeLaSemana = fechaNacimiento.DayOfWeek;
            Console.WriteLine("Naciste un día: " + diaDeLaSemana);
        }
        catch (FormatException)
        {
            Console.WriteLine("ingresala como s debe");
        }
    }
}
