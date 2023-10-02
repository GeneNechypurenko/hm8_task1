using hm8_task1;

MusicalInstrument[] instruments = new MusicalInstrument[]
{
    new Violin(),
    new Trombone(),
    new Ukulele(),
    new Cello(),
};

Console.WriteLine("Choose an instrument:\n");

for (int i = 0; i < instruments.Length; ++i)
{
    Console.Write($"{i + 1}. ");
    instruments[i].Desc();
}

int choice = int.Parse(Console.ReadLine());
Console.WriteLine();

if (choice >= 1 && choice <= instruments.Length)
{
    Console.WriteLine("1. Play Sound");
    Console.WriteLine("2. Show Information");
    Console.WriteLine("3. Show History");

    int action = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (action)
    {
        case 1:
            instruments[choice - 1].Sound();
            break;
        case 2:
            instruments[choice - 1].Show();
            break;
        case 3:
            instruments[choice - 1].History();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}
else
{
    Console.WriteLine("Invalid choice.");
}