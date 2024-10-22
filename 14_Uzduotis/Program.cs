Console.WriteLine("Iveskite metines pajamas (eur)");
double pajamos = double.Parse(Console.ReadLine());

Console.WriteLine("Iveskite esamus isipareigojimus (eur)");
double isipareigojimai = double.Parse(Console.ReadLine());

Console.WriteLine("Iveskite darbo staza (metais)");
double stazas = double.Parse(Console.ReadLine());

if (pajamos * 0.4 > isipareigojimai && pajamos > 25000)
{
    if (stazas > 2)
    {
        Console.WriteLine("Jus turit gerą galimybę gauti paskolą");
    }
    else { Console.WriteLine("Jum reikia daugiau laiko"); }
}
else
{
    Console.WriteLine("Jus galit turėti sunkumų gauti paskolą.");
}