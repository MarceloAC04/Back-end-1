int y = 1;
int x = 1;

while (y <= 10)
{
    int i = 1;
    do
    {
        Console.WriteLine($"{x * i}");
        i++;
    }
    while (i <= 10);
    y++;
    x++;
}
