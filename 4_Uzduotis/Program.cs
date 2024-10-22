Console.WriteLine("Iveskite raidę");
char x= char.Parse( Console.ReadLine());

if ("aeiouąęėįųū".Contains(Char.ToLower(x)))
{
    Console.WriteLine("ivesta raidė yra balsė");
}
else if (Char.IsLetter(x)) {
    Console.WriteLine("ivesta raidė yra priėbalsė");
}
