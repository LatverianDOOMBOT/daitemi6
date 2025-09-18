// See https://aka.ms/new-console-template for more information

float diffToKelvin = -273.15f;
Console.WriteLine("Type Temp inputted: ");
string typeTemp = Console.ReadLine();
typeTemp = typeTemp.ToLower();

if (typeTemp == "celcius")
{
    Console.WriteLine("Input: ");
    float t = float.Parse(Console.ReadLine());
    Console.WriteLine(t - diffToKelvin);
}else if (typeTemp == "kelvin")
{
    Console.WriteLine("Input: ");
    float t = float.Parse(Console.ReadLine());
    Console.WriteLine(t + diffToKelvin);
}


