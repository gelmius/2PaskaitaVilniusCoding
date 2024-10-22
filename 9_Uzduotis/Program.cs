Console.WriteLine("Iveskite skaiciu");
int x = int.Parse(Console.ReadLine());

if(x>0 && x - 9 > 0)
{
    Console.WriteLine("skaicius yra teigiamas dvizenklis");
}
else
{
    Console.WriteLine("skaicius yra neigiamas arba vienazenklis");
}
