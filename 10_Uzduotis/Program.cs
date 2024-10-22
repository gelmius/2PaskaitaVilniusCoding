Console.WriteLine("Iveskite skaiciu");
int x = int.Parse(Console.ReadLine());

if (x % 2 == 0 )
{
    Console.WriteLine("skaicius yra lyginis");

    if (x > 20)
    {
        Console.WriteLine("skaicius yra didesnis uz 20");
        if (x % 4 == 0)
        {
            Console.WriteLine("skaicius dalinasi is 4");
        }
        else
        {
            Console.WriteLine("skaicius nesidalinasi is 4");
        }
    }
    else
    {
        Console.WriteLine("skaicius yra mazesnis uz 20");
        if (x % 4 == 0)
        {
            Console.WriteLine("skaicius dalinasi is 4");
        }
        else
        {
            Console.WriteLine("skaicius nesidalinasi is 4");
        }
    }
}
else
{
    Console.WriteLine("skaicius yra nelyginis");
    if (x > 20)
    {
        Console.WriteLine("skaicius yra didesnis uz 20");
        if (x % 4 == 0)
        {
            Console.WriteLine("skaicius dalinasi is 4");
        }
        else
        {
            Console.WriteLine("skaicius nesidalinasi is 4");
        }
    }
    else
    {
        Console.WriteLine("skaicius yra mazesnis uz 20");
        if (x % 4 == 0)
        {
            Console.WriteLine("skaicius dalinasi is 4");
        }
        else
        {
            Console.WriteLine("skaicius nesidalinasi is 4");
        }
    }
}
