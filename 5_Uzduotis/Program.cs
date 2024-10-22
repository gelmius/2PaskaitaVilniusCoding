Console.WriteLine("Iveskite 3 kraštibnes");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());

if(x1 < x2 + x3  && x2 <x1 + x3 && x3 < x1 + x2)
{
    Console.WriteLine("sudaro trikampį pagal trikampio nelygybės taisyklę");
}
else
{
    Console.WriteLine("Nesudaro trikampio");
}