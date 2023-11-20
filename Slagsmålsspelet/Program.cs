using System;

int GoodPersonHP = 100;   
int BadPersonHP = 100;

Console.WriteLine("Vad heter den goda personen");

string GoodPersonName = Console.ReadLine();

Console.WriteLine("Vad heter den onda personen");

string BadPersonName = Console.ReadLine();

Random generator = new Random();

while (GoodPersonHP > 0 && BadPersonHP > 0)
{

    Console.WriteLine("\n------NY RUNDA------");
    Console.WriteLine($"{GoodPersonName}: {GoodPersonHP} {BadPersonName}: {BadPersonHP}\n");

    int GoodPersonDamage = generator.Next(20);
    BadPersonHP -= GoodPersonDamage;
    BadPersonHP = Math.Max(0, BadPersonHP);
    Console.WriteLine($"{GoodPersonName} gör {GoodPersonDamage} skada på {BadPersonName}");

    int BadPersonDamage = generator.Next(20);
    GoodPersonHP -= BadPersonDamage;
    GoodPersonHP = Math.Max(0, GoodPersonHP);
    Console.WriteLine($"{BadPersonName} gör {BadPersonDamage} skaga på {GoodPersonName}");
    
    Console.WriteLine("Tryck på valfri knapp för att fortsätta");
    Console.ReadKey();


}

Console.WriteLine("------Striden är slut------");

if (GoodPersonHP == 0 && BadPersonHP == 0)
{
    Console.WriteLine("Stridend blev oavgjord");
}

else if (GoodPersonHP == 0)
{
    Console.WriteLine($"{BadPersonName} vann");

}

else
{
    Console.WriteLine($"{GoodPersonName} vann");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta");
Console.ReadKey(); 