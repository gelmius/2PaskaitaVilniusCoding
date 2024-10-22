Console.WriteLine("Iveskite savaitės dienos numerį");
int x = int.Parse(Console.ReadLine());
switch (x)
{
	case 1: Console.WriteLine("Pirmadienis");
		break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Trečiadienis");
        break;
    case 4:
        Console.WriteLine("Ketvirtadienis");
        break;
    case 5:
        Console.WriteLine("Penktadienis");
        break;
    case 6:
        Console.WriteLine("Šeštadienis");
        break;
    case 7:
        Console.WriteLine("Sekmadienis");
        break;

    default:
		break;
}