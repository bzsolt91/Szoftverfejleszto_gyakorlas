namespace Kalapacsvetes
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string fejlec = "";
            List<Sportolo> sportoloEmber = new List<Sportolo>();
            try
            {
               
                using (var reader = new StreamReader("kalapacsvetes.txt ",System.Text.Encoding.UTF8))
                {
                     fejlec = reader.ReadLine();
                    string sor = "";
                    while ((sor = reader.ReadLine()) != null)
                    {
                        sportoloEmber.Add(new Sportolo(sor));
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
            Console.Write("4. Feladat: ");
            Console.Write(sportoloEmber.Count.ToString()+" dobás eredménye látható.");
            Console.WriteLine();
            Console.Write("5. Feladat: ");
            float dobasokOsszege=0;
            float hunSzamlalo = 0;
            foreach (var elem in sportoloEmber)
            {
                if (elem.OrszagKod == "HUN")
                {
                    dobasokOsszege += elem.Eredmeny;
                    hunSzamlalo++;
                }
            }
            Console.WriteLine($"A magyar sportolók átlagosan {(dobasokOsszege/hunSzamlalo)} dobotak");
            Console.WriteLine("6. Feladat: Adjon meg egy évszámot!");
            int  beolvasottEv = System.Convert.ToInt32( Console.ReadLine());
            int evSzamlalo = 0;
          List<string> talaltNevek= new List<string>();
            foreach (var elem in sportoloEmber)
            {
                if (elem.Datum.Year == beolvasottEv)
                {
                    talaltNevek.Add(elem.Nev);
                    evSzamlalo++;
                }
            }
            if (evSzamlalo > 0)
                Console.WriteLine($"{evSzamlalo} dobás került be az évben.");
            else
            {
                Console.WriteLine("Egy dobás sem került a legjobbak közé az évben.");
            }
                foreach (var elem in talaltNevek)
                {
                    Console.WriteLine(elem);
                }
            Console.WriteLine("7. Feladat: Statisztika!");
            List<OrszagStatisztika> statisztika = new List<OrszagStatisztika>();
            for (int i = 0; i < sportoloEmber.Count; i++)
            {
                string kod = sportoloEmber[i].OrszagKod;
                bool megtalalta = false;

                for (int j = 0; j < statisztika.Count; j++)
                {
                    if (statisztika[j].OrszagKod == kod)
                    {
                        statisztika[j].DobasokSzama++;
                        megtalalta = true;
                        break;
                    }
                }

                if (!megtalalta)
                {
                    statisztika.Add(new OrszagStatisztika(kod, 1));
                }
            }

            foreach (var elem in statisztika)
            {
                Console.WriteLine(elem.OrszagKod+" "+ elem.DobasokSzama);
            }

            string magyarSportolok=fejlec+"\n";
            foreach (var elem in sportoloEmber)
            {
                if (elem.OrszagKod == "HUN")
                    magyarSportolok+=elem.ToString() + "\n";
            }
            File.WriteAllText("magyarok.txt",magyarSportolok);
        }
        
        class OrszagStatisztika
        {
            public string OrszagKod { get; set; }
            public int DobasokSzama { get; set; }

            public OrszagStatisztika(string orszagKod,int dobasokSzama)
            {
                OrszagKod = orszagKod;
                DobasokSzama = dobasokSzama;
            }
        }
        public class Sportolo 
        {
            private short helyezes;
            private float eredmeny;
            private string nev;
            private string orszagKod;
            private string helyszin;
            private DateTime datum;

            public short Helyezes { get { return helyezes;  }set { this.helyezes = value; } } 
            public float Eredmeny { get { return eredmeny; }set { this.eredmeny = value; } }
            public string Nev { get { return nev; }set { this.nev = value; } }
            public string OrszagKod { get { return orszagKod; }set { this.orszagKod = value; } }
            public string Helyszin { get { return helyszin; } set { this.helyszin = value; } }
            public DateTime Datum { get { return datum; }set { this.datum = value; } }


            public Sportolo(string adatSor)
            {
                var adatok = adatSor.Split(";");
                this.helyezes = System.Convert.ToInt16(adatok[0]);
                this.eredmeny = float.Parse(adatok[1],new System.Globalization.CultureInfo("hu-HU"));
                 this.nev = adatok[2];
                this.orszagKod = adatok[3];
                this.helyszin =adatok[4];
               this.datum = DateTime.Parse(adatok[5],System.Globalization.CultureInfo.InvariantCulture);
            }
            public string ToString()
            {
                return helyezes.ToString() + ";" + eredmeny.ToString() + ";" + nev + ";" + orszagKod + ";" + helyszin + ";" + datum.ToString();
            }

        }
    }
}
