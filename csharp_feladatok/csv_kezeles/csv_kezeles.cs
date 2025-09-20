using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace csv_kezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember Gizi = new Ember("Kiss Gizella",37,159,53);
            List<Ember> szemelyek = new List<Ember>();
               try
                {
            using (StreamReader sr = new StreamReader("mint_adatok.csv"))
            {
                string fejlec = sr.ReadLine();  // Fejléc kiolvasása
                string sor;

                while ((sor = sr.ReadLine()) != null)
                {
                    string[] adatmezok = sor.Split(',');

                    if (adatmezok.Length == 4)
                    {
                        string nev = adatmezok[0];
                        int eletkor = int.Parse(adatmezok[1]);

                        //     float magassag = float.Parse(adatmezok[2].Replace(',', '.'));

                        string magassagString = adatmezok[2].Replace(',', '.');
                        float magassag = float.Parse(magassagString, CultureInfo.InvariantCulture);

                        // Ha a súly "-" akkor alapértelmezett értéket adunk
                        string sulyString = adatmezok[3] == "-" ? "100" : adatmezok[3].Replace(',', '.');
                        float suly = float.Parse(sulyString, CultureInfo.InvariantCulture);

                        szemelyek.Add(new Ember(nev, eletkor, magassag, suly));
                    }
                }
            }
                 }
                 catch {
                     Console.WriteLine("hiba");
                 }
            
            foreach (var sz in szemelyek ) 
            {
                Console.WriteLine(sz.Nev);
            }
            Console.WriteLine("8. feladat");
            Console.WriteLine("kinél fiatalabbakat szertenél látni?");
            string kinel = Console.ReadLine();
            Boolean benne_van = false;
            int eletkora =0;
            foreach (var szemely in szemelyek)
            {
                if (szemely.Nev == kinel)
                {
                    benne_van = true;
                    eletkora = szemely.Eletkor;
                    break;
                }
            }
            if (benne_van)
            {
                foreach (var szemely in szemelyek)
                {
                    if(eletkora > szemely.Eletkor)
                    {
                        Console.WriteLine($"{szemely.Nev} {szemely.Eletkor}");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Nincs ilyen szermély");
            }


        }
        
        class Ember
        {
            string nev;
            int eletkor;
            float magassag;
            float suly;
            public string Nev
            {
                get { return nev; }
                set {
                    if (nev != value)
                        nev = value;
                
                }
            }
            public int Eletkor
            {
                get { return eletkor; }
                set { eletkor = value; }
            }
            public float Magassag 
            {
                get { return magassag; }
                set { magassag = value; }
            }
            public float Suly
            {
                get { return suly; }
                set { suly = value; }
            }
            public Ember(string nev,int eletkor, float magassag,float suly) 
            {
                this.nev = nev;
                this.eletkor = eletkor;
                this.magassag = magassag;
                this.suly = eletkor;

            }
            public double BMI()
            {
                double bmi = ((suly / 1.0) / (magassag * magassag) * 10000);
                return bmi;
            }
        }
    }
}
