
Random random = new Random();


int atsitiktinisSkaicius = random.Next(1, 101);
Console.WriteLine(atsitiktinisSkaicius);

switch (atsitiktinisSkaicius)
{
    case int n when (n >= 1 && n <= 20):
        Console.WriteLine("Laimeta maza premija");
        break;
    case int n when (n >= 21 && n <= 50):
        Console.WriteLine("Laimeta vidutinė premija");
        break;
    case int n when (n >= 51 && n <= 90):
        Console.WriteLine("Laimeta didelė premija");
        break;
    case int n when (n >= 91 && n <= 100):
        Console.WriteLine("Jackpot!");
        break;
    default:
        break;
}
