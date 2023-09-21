using System;
using System.Collections.Generic;
using Uppgift_Fordon;

int val = 0;
Fordon fordon = null;
List<Fordon> FordonLista = new List<Fordon>();
//FordonLista.Add("Bil", 2023, 2);

while(val !=3)
{
    Console.WriteLine("Skriv 1 för att lägga till en fordon");
    Console.WriteLine("Skriv 2 för att skriva ut information");
    Console.WriteLine("Skriv 3 för att avsluta programet"); //
    val = int.Parse(Console.ReadLine()); //

    if(val == 1)
    {
        Console.WriteLine("Skriv 1 för att lägga till Bil");
        Console.WriteLine("Skriv 2 för att lägga till Buss");
        Console.WriteLine("Skriv 3 för att lägga till Mobed");
        int valfordon = int.Parse(Console.ReadLine());
        if (valfordon == 1)
        {
            Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
            fordon = new Bil(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        else if(valfordon == 2)
        {
            Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
            fordon = new Buss(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        else if(valfordon == 3)
        {
            Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
            fordon = new Mobed(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
    }

    else if(val == 2)
    {
        fordon.SkrivUt();
    }

    else if (val == 3)
    {
        Console.WriteLine("Programet avslutades");
    }
}