Random random = new Random();


int atsitiktinisSkaicius = random.Next(-30, 41);

switch (atsitiktinisSkaicius)
{
    case int n when ( n < -10):
        Console.WriteLine("Stipri šalna");
        Console.WriteLine("Apsirenkite labai šiltai");
        break;
    case int n when (n >= -10 && n <= 0):
        Console.WriteLine("Šalna");
        Console.WriteLine("Apsirenkite šiltai");
        break;
    case int n when (n >= 1 && n <= 15):
        Console.WriteLine("Vėsu");
        Console.WriteLine("Apsirenkite šiltai bet ne per šiltai ");
        break;
    case int n when (n >= 16 && n <= 25):
        Console.WriteLine("Šilta");
        Console.WriteLine("Apsirenkite vasariskai");
        break;
    case int n when (n > 25):
        Console.WriteLine("Karšta");
        Console.WriteLine("Važiuokite prie ežero");
        break;
    default:
        break;
}
