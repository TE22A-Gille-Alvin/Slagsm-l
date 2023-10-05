using System.Runtime.InteropServices;

int Kennyhp = 100;
int Kentahp = 100;
Random generator = new Random();

Console.WriteLine("Welcome to THE fighter game, press button to start");
Console.ReadLine();

while (Kennyhp > 0 && Kentahp > 0)
{
    Console.WriteLine("NEW ROUND");
    Console.WriteLine($"Kenny: {Kennyhp} Kenta: {Kentahp}");

    int Kennydamage = generator.Next(1, 21);
    Kentahp -= Kennydamage;
    Console.WriteLine($"Kenny does {Kennydamage} damage to Kenta");

    int Kentadamage = generator.Next(1, 21);
    Kennyhp -= Kentadamage;
    Console.WriteLine($"Kenta does {Kentadamage} damage to Kenny");

    Console.WriteLine($"Kenny: {Kennyhp} Kenta: {Kentahp}");

    Console.WriteLine("Press button to continue");
    Console.ReadLine();
}

Console.WriteLine("End of battle");
if (Kennyhp <= 0 && Kentahp <= 0)
{
    Console.WriteLine("Draw");
}
else if (Kennyhp == 0)
{
    Console.WriteLine("Kenta WON!");
}
else
{
    Console.WriteLine("Kenny WON!");
}

Console.ReadLine();