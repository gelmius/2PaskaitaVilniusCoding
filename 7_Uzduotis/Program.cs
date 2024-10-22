Console.WriteLine("Iveskite el. pasta");
string x = Console.ReadLine();

if(x != null && x.Contains('@') && (x.Contains(".lt") || x.Contains(".com")))
{
    Console.WriteLine("El pasto adresas geras");
}
else
{
    Console.WriteLine("El pasto tuscias arba negeras");
}