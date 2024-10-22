Random random = new Random();


int atsitiktinisSkaicius = random.Next(0, 24);

Console.WriteLine("Dabar : "+atsitiktinisSkaicius+" val.");

Console.WriteLine("Kava megstate su cukrumi? taip - y, ne - n");
char cukrus = Char.Parse(Console.ReadLine());

switch (atsitiktinisSkaicius)
{
    case int n when (n >= 6 && n < 10):
        Console.WriteLine("Rekomenduoju stipria juoda kava");
        break;
    case int n when (n >= 10 && n < 14):
        Console.WriteLine("Rekomenduoju latte ar cappuccino");
        break;
    case int n when (n >= 14 && n < 18):
        Console.WriteLine("Rekomenduoju espresso ar šaltą kavą");
        break;
    case int n when (n >= 18):
        Console.WriteLine("Rekomenduoju vengti kavos arba kava be kofeino");
        if(cukrus == 'n')
        {
            Console.WriteLine("Pranesima apie kofeino poveiki miegui");
        }
        break;
    default:
        Console.WriteLine("Eik miegoti");
        break;
}
