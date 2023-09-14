using System;
using Uppgift_Fordon;

Console.WriteLine("Vilken typ av fordon vill du lägga till?");
Console.WriteLine("Skriv 1 för Bil");
Console.WriteLine("Skriv 2 för Buss");
Console.WriteLine("Skriv 3 för Mobed");
Console.WriteLine("Skriv 4 för att avsluta programet");
int val = int.Parse(Console.ReadLine());

Fordon fordon = null;

while(val !=4)
{
    if (val == 1)
    {
        Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
        fordon = new Bil(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
    else if(val == 2)
    {
        Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
        fordon = new Buss(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
    else if(val == 3)
    {
        Console.WriteLine("Skriv model, år och vikt i ton på var enda linje");
        fordon = new Mobed(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
    else if (val == 5)
    {
        Console.WriteLine("Programet avslutas");
        break;
    }
    
    Console.WriteLine("Skriv 1 för att lägga till en bill"); //
    Console.WriteLine("Skriv 2 för att skriva ut information"); //

    Console.WriteLine("Skriv 1 för Bil"); //
    Console.WriteLine("Skriv 2 för Buss"); //
    Console.WriteLine("Skriv 3 för Mobed"); //
    Console.WriteLine("Skriv 5 för att avsluta programet"); //
    val = int.Parse(Console.ReadLine());
    fordon.SkrivUt();
}