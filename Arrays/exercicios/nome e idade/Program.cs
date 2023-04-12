string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome");
    nomes[i] = Console.ReadLine();
    Console.WriteLine($"Informe a {i + 1}º idade");
    idades[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($" ");

for (int y = 0; y < nomes.Length; y++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{y + 1}) nome: {nomes[y]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"   idade: {idades[y]} anos");
    Console.ResetColor();
    Console.WriteLine($"");
}
