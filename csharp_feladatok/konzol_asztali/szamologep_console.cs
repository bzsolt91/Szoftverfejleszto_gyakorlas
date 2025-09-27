using System.Runtime.CompilerServices;

byte menu_kiiras() 
{
    Console.Clear();
    Console.WriteLine("Számológép");
    Console.WriteLine("Lehetséges műveletek:");
    Console.WriteLine("1.Összeadás");
    Console.WriteLine("2.kivonás");
    Console.WriteLine("3.szorzás");
    Console.WriteLine("4.osztas");
    Console.WriteLine("5.hatványozás");
    Console.WriteLine("-----------------");
    Console.WriteLine("0. Kilépés a programból");
    Console.WriteLine("*************************************");

    byte menupont_szama = System.Convert.ToByte(Console.ReadLine());
    return menupont_szama;
    
}
void osszeadas()
{
    int elso_szam, masodik_szam;
    Console.Clear();
    Console.WriteLine("Összeadás:");
    Console.WriteLine("Kérem az első számot");
    elso_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Kérem a második számot");
    masodik_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Eredmény:" + System.Convert.ToString(elso_szam + masodik_szam));
    Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
    Console.ReadKey();
}
void kivonas()
{
    int elso_szam, masodik_szam;
    Console.Clear();
    Console.WriteLine("Kivonás:");
    Console.WriteLine("Kérem az első számot");
    elso_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Kérem a második számot");
    masodik_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Eredmény:" +System.Convert.ToString(elso_szam - masodik_szam));
    Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
    Console.ReadKey();
}
void osztas()
{
    double elso_szam, masodik_szam;
    Console.Clear();
    Console.WriteLine("Osztás:");
    Console.WriteLine("Kérem az első számot");
    elso_szam = System.Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Kérem a második számot");
    masodik_szam = System.Convert.ToDouble(Console.ReadLine());
    if (elso_szam != 0 && masodik_szam != 0)
        Console.WriteLine("Eredmény:" + System.Convert.ToString(elso_szam / masodik_szam));
    else
    {
        Console.WriteLine("Nullával nem osztunk");
        Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
        Console.ReadKey();
    }
}
void szorzas()
{
    int elso_szam, masodik_szam;
    Console.Clear();
    Console.WriteLine("Szorzás:");
    Console.WriteLine("Kérem az első számot");
    elso_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Kérem a második számot");
    masodik_szam = System.Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Eredmény:" + System.Convert.ToString(elso_szam * masodik_szam));
    Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
    Console.ReadKey();
}
void hatvanyozas()
{
    double elso_szam, masodik_szam;
    Console.Clear();
    Console.WriteLine("Hatványozád:");
    Console.WriteLine("Kérem az első számot");
    elso_szam = System.Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Kérem a második számot");
    masodik_szam = System.Convert.ToDouble(Console.ReadLine());

    double eredmeny = Math.Pow(elso_szam, masodik_szam);
    Console.WriteLine("Eredmény:" + eredmeny.ToString());
    Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
    Console.ReadKey();
}

while (true)
{
    try
    {
        byte valasztott_menu =menu_kiiras();
        if (valasztott_menu <= 5 && valasztott_menu !=0)
        {
            

            switch (valasztott_menu)
            {
                case 1:
                    osszeadas();
                    break;
                case 2:
                    kivonas();
                    break;
                case 3:
                    szorzas();
                    break;
                case 4:
                    osztas();
                    break;
                case 5:
                    hatvanyozas();
                    break;
                default:
                    Console.WriteLine("Nem jól választotta ki a műveletet!", "Hiba!");
                    Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
                    Console.ReadKey();
                    break;
            }
        }
        else if(valasztott_menu!=0)
        {
            Console.WriteLine("Nem jól választotta ki a műveletet!", "Hiba!");
            Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
            Console.ReadKey();
            continue;
        }

        if (valasztott_menu == 0)
        {
            break;
            
        }
    }


    catch (FormatException)
    {
        Console.WriteLine("Hibás adatbevitel! Kérem, számot adjon meg.");
        Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ismeretlen hiba történt: {ex.Message}");
        Console.WriteLine("Folytatáshoz nyomjon meg egy billentyűt");
        Console.ReadKey();
    }

}


