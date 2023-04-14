int y = 1;
int x = 1;

while (y <= 10)
{
    Console.ForegroundColor = ConsoleColor.Green;
    int i = 1;
    Console.WriteLine($"Tabuada do {x}");
    Console.ResetColor();
    do
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{x} x {i} = {x * i}");
        i++;
        Console.ResetColor();
    }
    while (i <= 10);
    y++;
    x++;
}
