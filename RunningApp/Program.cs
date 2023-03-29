// See https://aka.ms/new-console-template for more information
using RunLib.model;

Console.WriteLine("Hello, World!");


Medlem medlem1 = new Medlem();
Medlem medlem2 = new Medlem("Peter",222,"33445566","gul", 120 );
Console.WriteLine(medlem1);
Console.WriteLine(medlem2);

try
{
    medlem1.Navn = "Pi";
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

try
{
    medlem1.Mobil = "1234567";
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

try
{
    medlem1.LøbeHold = "agurk";
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

try
{
    medlem1.Pris = 49;
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

Console.WriteLine("Enum");
Medlem nytMedlem = new Medlem("Jakob", 345, "66555566", "blå", 100, MedlemsType.ung);
Console.WriteLine(nytMedlem);