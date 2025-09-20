//------- globális változók -----
int[] tomb = new int[10];

//------------ függvények ------

void feltolt()
{
    Random rnd = new Random();

     for (int i = 0; i < 10; i++)
     {
         tomb[i] = rnd.Next(10, 100);
     }
    /*
    for (int i = 0; i < 10; i++)
    {
        tomb[i] = 99 - i;
    }
    */
}


void kiir()
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{tomb[i]} ");
    }
    Console.WriteLine();
}

void csere(int hanyadikat, int hanyadikra)
{
    /*int a = 11;
    int b = 12;
    int seged;
    Console.WriteLine($"{a}, {b}");
    seged = a;
    a = b;
    b = seged;
    Console.WriteLine($"{a}, {b}");*/
    int seged;
    seged = tomb[hanyadikat];
    tomb[hanyadikat] = tomb[hanyadikra];
    tomb[hanyadikra] = seged;
}

void egy_buborek()
{
    for (int i = 0; i < 9; i++)
    {
        if (tomb[i] > tomb[i + 1])
            csere(i, i + 1);
    }
}

void buborekos_rendezes()
{
    for (int i = 0; i < 9; i++)
    {
        //Console.WriteLine($"{i + 1}. buborék:");
        egy_buborek();
        //kiir();
    }
}

//------------ főprg -----------

feltolt();
kiir();
Console.WriteLine();
buborekos_rendezes();
kiir();
