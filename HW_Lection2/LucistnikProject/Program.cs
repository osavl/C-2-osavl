
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Lucistnik lucistnik = new Lucistnik("Robin Hood", 10);

        while (true)
        {
            lucistnik.ZobrazStav();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Vystřelit šíp");
            Console.WriteLine("2. Přidat šípy");
            Console.WriteLine("3. Konec");
            Console.Write("Vyberte možnost: ");
            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    lucistnik.Vystrel();
                    break;
                case "2":
                    int pocetSipu = NactiCeleCisloZKonzole("Zadejte počet šípů k přidání: ");
                    lucistnik.PridejSipy(pocetSipu);
                    break;
                case "3":
                    Console.WriteLine("Konec programu.");
                    return;
                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
        }
    }

    public static int NactiCeleCisloZKonzole(string vyzva)
    {
        int cislo;
        while (true)
        {
            Console.Write(vyzva);
            string vstup = Console.ReadLine();
            if (int.TryParse(vstup, out cislo) && cislo >= 0)
            {
                return cislo;
            }
            else
            {
                Console.WriteLine("Neplatné číslo, zkuste to znovu.");
            }
        }
    }
}
