using System;

class Program
{
    static void Main()
    {
        // Introducerea datei de nastere
        Console.WriteLine("Introduceti data de nastere (in formatul DD.MM.YYYY):");
        string dataNasteriiInput = Console.ReadLine();
        DateTime dataNasterii;

        // Analiza datei de nastere cu formatul specificat
        if (DateTime.TryParseExact(dataNasteriiInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dataNasterii))
        {
            // Calcularea diferentei de timp
            DateTime dataCurenta = DateTime.Now;
            TimeSpan durata = dataCurenta - dataNasterii;

            // Extrageți componentele dorite din diferența de timp
            int ani = durata.Days / 365;
            int luni = durata.Days % 365 / 30;
            int saptamani = durata.Days % 365 % 30 / 7;
            int zile = durata.Days % 365 % 30 % 7;
            int ore = durata.Hours;
            int minute = durata.Minutes;

            // Afișarea rezultatelor
            Console.WriteLine($"Ati trait aproximativ {ani} ani, {luni} luni, {saptamani} saptamani, {zile} zile, {ore} ore si {minute} minute.");
        }
        else
        {
            Console.WriteLine("Formatul datei introduse este invalid.");
        }
    }
}
