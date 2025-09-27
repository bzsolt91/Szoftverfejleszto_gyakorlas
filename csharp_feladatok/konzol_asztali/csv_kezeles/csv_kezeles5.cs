namespace file5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = "emberek.csv";
            string[] readlines = File.ReadAllLines(fajl);
            Boolean fejlec = true;
            float szumma = 0;
            int sorok_szama = 0;
            foreach (string line in readlines)
            {
                if (fejlec) //első fejléc sor kihagyása
                {
                    fejlec = false;
                    continue;
                }
                //feldolgozas
                string[] adatok = line.Split(";");
                szumma += Convert.ToInt32(adatok[2]);
                sorok_szama++;
                Console.WriteLine(line);
            }

            Console.WriteLine($"szumma: {szumma/(sorok_szama)}");
        }
    }
}
