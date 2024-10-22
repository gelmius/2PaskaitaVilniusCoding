Console.WriteLine("Iveskite 3 kraštibnes");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());

if(x1 == x2 && x1!= x3)
{
    Console.WriteLine("Gali sudaryti lygiasoni trikampi");
}
else if(x1 == x3 &&  x1!= x2)
{
    Console.WriteLine("Gali sudaryti lygiasoni trikampi");
}
else if(x3 == x2 && x3!= x1)
{
    Console.WriteLine("Gali sudaryti lygiasoni trikampi");
}
else if(x3 == x2 && x3 == x1)
{
    Console.WriteLine("Gali sudaryti lygiasoni trikampi");
}
else
{
    Console.WriteLine("Negali sudaryti lygiasoni trikampi");
}
