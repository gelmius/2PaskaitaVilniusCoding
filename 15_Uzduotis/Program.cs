// See https://aka.ms/new-console-template for more information
Console.WriteLine("kiek kambariu buto nuomos norite?");
int kambariusSkaicius = Int32.Parse(Console.ReadLine());

Console.WriteLine("Iveskite nuomos kaina");
int nuomosKaina = Int32.Parse(Console.ReadLine());
switch (kambariusSkaicius)
{
    case 1:

        if (nuomosKaina<500)
        {
            Console.WriteLine("Nuomos kaina tinkama");
        }
        else
        {
            Console.WriteLine("Nuomos kaina per brangi");
        }
        break;
    case 2:
        goto KambriuButas23;
        break;
    case 3:
        goto KambriuButas23;
        break;

    default:
        break;
}

KambriuButas23:
if (nuomosKaina < 1000)
{
    Console.WriteLine("Nuomos kaina yra prieinama, nepamirskite apie galimus papildomus mokescius ");
}