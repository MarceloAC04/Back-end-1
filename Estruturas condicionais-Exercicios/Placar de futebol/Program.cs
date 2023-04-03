int timeCasa;
int timeVisitante;

Console.WriteLine($"Informe os gols do time da casa");
timeCasa = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gols do time visitante");
timeVisitante = int.Parse(Console.ReadLine());


if (timeCasa > timeVisitante)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Vitória do time da casa!");
    Console.ResetColor();
}
else if (timeCasa == timeVisitante)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"Empate!");
    Console.ResetColor();
}
else 
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Vitória do time visitante!");
    Console.ResetColor();
}
