Console.WriteLine("Iveskite varda");
string x = Console.ReadLine();

if (x.Length > 5)
{
    Console.WriteLine("vardas ilgesnis nei 5, " +  x.Length);
}
else
{
    Console.WriteLine("vardas trumpesnis nei 5, " + x.Length);

}