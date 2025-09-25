// See https://aka.ms/new-console-template for more information

float diffToKelvin = -273.15f; // 1. vupros - dobavq se watch nz dali se e promenila ne sum proveril
Console.WriteLine("Type Temp inputted: ");
string typeTemp = Console.ReadLine();
typeTemp = typeTemp.ToLower();


if (!string.IsNullOrEmpty(typeTemp)) // ne mi se pishat 10000 takiva stiga tolkova nqma da proverqvam float t
{
    float t = float.Parse(Console.ReadLine()); // samo edin put se chete conzolata
    if (typeTemp == "celcius")
    {
        Console.WriteLine("Input: ");

        t = t - diffToKelvin;
    }
    else if (typeTemp == "kelvin")
    {
        Console.WriteLine("Input: ");

        t = t + diffToKelvin;
    }
    Console.WriteLine($"Converted Temp: {t}"); //ppc ne sum se setil za teq raboti shoto programite gi pravq za 5 min na kraq na chasa
}



