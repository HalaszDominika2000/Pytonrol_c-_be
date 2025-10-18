using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //udvozles(); /*Metodus meghivasa*/
        //hengerszamitas();
        //szamBekeres();
        //primszamE();
        evszamBekero();
    }
    static void udvozles() /*Ez a metodus*/
    {
        /*1. Feladat*/
        Console.Write("Kérlek, add meg a neved: ");
        string nev = Console.ReadLine();

        Console.WriteLine($"Üdvözöllek, {nev}!"); /* Line az a sortörés ebben a parancsban: WriteLine*/

    }
    static void hengerszamitas()
    {
        /*Double törtszam*/
        Console.Write("Add meg a henger sugarát (r): ");
        /*Console.Readline string tipusu ezért át kell alakítani konvertálni a kívánt típusra azaz double-ra. To: val, vel*/
        double r = Convert.ToDouble(Console.ReadLine());
        Console.Write("Add meg a henger magasságát (h): ");
        double h = Convert.ToDouble(Console.ReadLine());
        /*Math.Pow(x,2) az x-et négyzetre emeli ez a fuggveny 3 is lehet ez köbre emeli*/
        double felszin = 2 * Math.PI * r * h + 2 * Math.PI * Math.Pow(r, 2);
        double terfogat = Math.PI * Math.Pow(r, 2) * h;
        Console.WriteLine($"A henger felszine: {felszin:F2}, a henger térfogata: {terfogat:F2}:  ");
    }
    static void szamBekeres()
    {
        Console.Write("Adj meg egy számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());
        if (szam % 7 == 0 && szam % 11 == 0 && szam % 13 == 0)
        {
            Console.Write("A szám oszthato 7-tel 11-gyel és 13-mal is.");
        }
        else if (szam % 7 == 0)
        {
            Console.Write("A szám oszthato 7-tel.");
        }
        else if (szam % 11 == 0)
        {
            Console.Write("A szám oszthato 11-gyel.");
        }
        else if (szam % 13 == 0)
        {
            Console.Write("yA szám oszthato 13-mal.");
        }
        else
        {
            Console.Write("A szám nem oszthato sem 7-tel 11-gyel és 13-mal.");
        }
    }
    static void primszamE()
    {
        Console.Write("Adj meg egy számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());
        if (szam < 2)
        {
            Console.Write($"{szam} nem prímszám.");
            return;
        }
        for (int i = 2; i < szam; i++)
        { //ameddig i kissebb mint szám adj hozzá plussz elemet itt az i az 2 a szám amit megadott a felhasználo
            if (szam % i == 0)
            {
                Console.Write($"{szam} nem prímszám.");
                return;
            }

        }
        Console.Write($"{szam} prímszám.");

    }
    static void evszamBekero()
    {
        Console.WriteLine("Mikor volt a Nyugat Romai Birodalom bukasa?");
        int evszam = Convert.ToInt32(Console.ReadLine());
        while (evszam != 476)
        {
            if (evszam < 476)
            {
                Console.WriteLine("Kesobbi datum.");
            }
            else
            {
                Console.WriteLine("Korabbi datum.");
            }
            Console.WriteLine("Mikor volt a Nyugat Romai Birodalom bukasa?");
            evszam = Convert.ToInt32(Console.ReadLine()); //Dekralácio nem szabad kétszer ezt a sort beilleszteni!!!!!! ebben az esetben az intet leszedem és itt maradhat
        }
        Console.WriteLine("Helyes válasz!");
    }
}