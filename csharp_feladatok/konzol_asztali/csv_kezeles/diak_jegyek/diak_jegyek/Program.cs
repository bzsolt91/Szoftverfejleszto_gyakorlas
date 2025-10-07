using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Diak> diakok = new List<Diak>();
        //List<Osztaly> osztalyok = new List<Osztaly>();

        try
        {
            using (StreamReader sr = new StreamReader("diak_jegyek.csv"))
            {
                string fejlec = sr.ReadLine(); // Fejléc sor kihagyása

                string sor;
                while ((sor = sr.ReadLine()) != null)
                {
                    Diak ujdiak = new Diak(sor);
                    diakok.Add(ujdiak);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba a fájl feldolgozásában!");
        }

        // 1. feladat - Hány diák jegyeit tartalmazza?
        Console.WriteLine($"1. feladat - Diákok száma a fájlban: {diakok.Count}");

        //2. fealdat - Hányan járnak a 7/a osztályba?
        int hetedik_a = 0;
        foreach (var diak in diakok)
        {
            if (diak.Osztaly == "7/a")
                hetedik_a++ ;            
        }
        Console.WriteLine($"2. feladat - Diákok száma a 7/a-ban: {hetedik_a}");

        //3. feladat - Hány osztály van?

        //4. fealadat - Legjobb tanuló
        double legjobb_atlag = 0.0;
        string legjobb_tanulo = "";
        //double legjobb_atlag = diakok[0].atlag();
        //string legjobb_tanulo = diakok[0].Nev;
        foreach (var diak in diakok)
        {
            if (diak.atlag() > legjobb_atlag)
            {
                legjobb_atlag = diak.atlag();
                legjobb_tanulo = diak.Nev;
            }
        }
        Console.WriteLine($"4. feladat - Legjobb diák: {legjobb_tanulo}");

        //5. feladat - Legrosszabb tanuló
        //double legrosszabb_atlag = 6.0;
        //string legrosszabb_tanulo = "semmi";
        double legrosszabb_atlag = diakok[0].atlag();
        string legrosszabb_tanulo = diakok[0].Nev;
        foreach (var diak in diakok)
        {
            if (diak.atlag() < legrosszabb_atlag)
            {
                legrosszabb_atlag = diak.atlag();
                legrosszabb_tanulo = diak.Nev;
            }
        }
        Console.WriteLine($"5. feladat - Legrosszabb diák: {legrosszabb_tanulo}");

        //8. feladat - Hányan buktak meg valamiből?
        int bukottak = 0;
        foreach (var diak in diakok)
        {
            if (diak.bukott() == true)
            //if (diak.bukott())
                bukottak++;
        }
        Console.WriteLine($"8. feladat - Bukottak száma: {bukottak}");
        
        //9. feladat - Hány Lili jár az osztályokba? (az összes osztályba)
        int Lilik = 0;
        foreach (var diak in diakok)
        {
            if (diak.keresztnev() == "Lili")
                Lilik++;
        }
        Console.WriteLine($"8. feladat - Lilik száma: {Lilik}");

        //Osztályok feldolgozása
        /* később visszatérünk!!!
        foreach (var diak in diakok)
        {
            foreach (var osztaly in osztalyok)
            {
                if (diak.Osztaly == osztaly.Nev)
                {
                   
                }
            }                
        }*/
    }
}

/*
class Osztaly
{
    public string Nev { get; set; }
    public int tanuloszam { get; set; }

    public Osztaly(string nev)
    {
        Nev = nev;
    }
}
*/

class Diak
{
    public string Nev { get; set; }
    public string Osztaly { get; set; }
    public int Magyar { get; set; }
    public int Matek { get; set; }
    public int Tortenelem { get; set; }
    public int Idegen_nyelv { get; set; }

    public Diak(string sor)
    {
        //Kiss Eszter,7/c,4,5,5,3
        string[] adatmezok = sor.Split(',');
        Nev = adatmezok[0];
        Osztaly = adatmezok[1];
        Magyar = adatmezok[2] == "d" ? 5 : int.Parse(adatmezok[2]);
        Matek = adatmezok[3] == "d" ? 5 : int.Parse(adatmezok[3]);
        Tortenelem = adatmezok[4] == "d" ? 5 : int.Parse(adatmezok[4]);
        Idegen_nyelv = adatmezok[5] == "d" ? 5 : int.Parse(adatmezok[5]);
    }

    public double atlag()
    {
        int szumma = Magyar + Matek + Tortenelem + Idegen_nyelv;
        return szumma / 4.0;
    }

    public Boolean bukott()
    {
        if ((Magyar == 1) || (Matek == 1) || (Tortenelem == 1) || (Idegen_nyelv == 1))
            return true;
        else 
            return false;
    }

    public string keresztnev()
    {
        string[] nevreszek = Nev.Split(' ');
        return nevreszek[1];
    }

}