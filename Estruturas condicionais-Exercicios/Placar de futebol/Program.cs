int timeCasa;
int timeVisitante;

Console.WriteLine($"Informe os gols do time da casa");
timeCasa = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gols do time visitante");
timeVisitante = int.Parse(Console.ReadLine());


if (timeCasa > timeVisitante)
{
    Console.WriteLine($"Vitória do time da casa!");
}
else if (timeCasa == timeVisitante)
{
    Console.WriteLine($"Empate!");
}
else 
{
    Console.WriteLine($"Vitória do time visitante!");
}
