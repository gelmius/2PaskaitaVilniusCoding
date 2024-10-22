Console.WriteLine("Iveskite skaiciu");
int x = int.Parse(Console.ReadLine());

if (x > 100)
{
    if (x % 10 == 0)
    {
        Console.WriteLine("ypatingas, didelis ir dalinasi is 10");
    }
    else
    {
        Console.WriteLine("paprastas");
    }
}