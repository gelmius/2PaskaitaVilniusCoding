Console.WriteLine("Iveskite el. pasta");
string x = Console.ReadLine();

if (x != null && x.Contains('@') && x.Contains("."))
{
    Console.WriteLine("El pasto adresas geras");
    if (x.Contains("@gmail.com") || x.Contains("@yahoo.com")) {
        Console.WriteLine("Tai yra populiarus el. pašto teikėjas.");
    }
    else
    {
        Console.WriteLine("Tai yra mažiau žinomas el. pašto teikėjas.");
    }
}   
else
{
    Console.WriteLine("El pasto tuscias arba negeras");
}