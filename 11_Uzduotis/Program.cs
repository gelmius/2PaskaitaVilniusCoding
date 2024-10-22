Console.WriteLine("Iveskite savo amžiu");
int amzius = int.Parse(Console.ReadLine());

if (18<=amzius && amzius <= 30)
{
    Console.WriteLine("Ar jus esate studentas? iveskite y, jei ne n");
    char studentas = Char.Parse(Console.ReadLine());
    if('y' == Char.ToLower(studentas))
    {
        Console.WriteLine("Jus galite gauti akademinę paramą");
    }
    else if('n' == Char.ToLower(studentas))
    {
        Console.WriteLine("Ar jus esate dirbantis? iveskite y, jei ne n");
        char dirbantis = Char.Parse(Console.ReadLine());
        if ('y' == Char.ToLower(dirbantis))
        {
            Console.WriteLine("Jus galite gauti stipendija");
        }
    }
}