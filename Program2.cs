using System;
using System.Globalization;

class Program2
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
        string monthName = firstDayOfMonth.ToString("MMMM", CultureInfo.CurrentCulture);
        int year = today.Year;

        Console.WriteLine($"{monthName} {year}");
        Console.WriteLine();

        Console.WriteLine("lu ma mi ju vi sá do");

        int startDay = (int)firstDayOfMonth.DayOfWeek;
        startDay = (startDay + 6) % 7;

        for (int i = 0; i < startDay; i++)
        {
            Console.Write("   ");
        }

        int daysInMonth = DateTime.DaysInMonth(year, today.Month);
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,2} ");
            if ((startDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        if ((startDay + daysInMonth) % 7 != 0)
        {
            Console.WriteLine();
        }
    }
}
