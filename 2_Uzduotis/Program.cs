Console.WriteLine("Iveskite amžiu");
int x = int.Parse(Console.ReadLine());

if (x < 13)
{
    Console.WriteLine("asmuo yra vaikas (mažiau 13)");
}
else if (x < 18)
{
    Console.WriteLine("paauglys (mažiau 18)");
}
else if (x >= 65)
{

    Console.WriteLine("suaugęs ar senjoras (daugiau lygu 65)");
}
else
{
    Console.WriteLine("amžius yra tarp 18 ir 65");
}

