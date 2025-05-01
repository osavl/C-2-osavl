
using System;

public class Lucistnik
{
    public string Jmeno { get; private set; }
    public int PocetSipu { get; private set; }

    public Lucistnik(string jmeno, int pocetSipu)
    {
        Jmeno = jmeno;
        PocetSipu = pocetSipu;
    }

    public void Vystrel()
    {
        if (PocetSipu > 0)
        {
            PocetSipu--;
            Console.WriteLine($"{Jmeno} vystřelil šíp. Zbývá {PocetSipu} šípů.");
        }
        else
        {
            Console.WriteLine($"{Jmeno} nemá žádné šípy.");
        }
    }

    public void PridejSipy(int pocet)
    {
        if (pocet > 0)
        {
            PocetSipu += pocet;
            Console.WriteLine($"{Jmeno} přidal {pocet} šípů. Nyní má {PocetSipu} šípů.");
        }
        else
        {
            Console.WriteLine("Počet šípů musí být kladný.");
        }
    }

    public void ZobrazStav()
    {
        Console.WriteLine($"Lučištník: {Jmeno}, Počet šípů: {PocetSipu}");
    }
}
