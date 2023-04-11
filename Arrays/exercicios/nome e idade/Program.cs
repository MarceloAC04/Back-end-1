string[] nomes = new string[5];
int[] idades = new int[5];
int y = 0;
int x = 1;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o seu nome");
    nomes[i] = Console.ReadLine();
    Console.WriteLine($"Informe sua idade");
    idades[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($" ");

foreach (string item in nomes)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{x}) nome: {item}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"idade: {idades[y]} anos");
    Console.ResetColor();

    Console.WriteLine($"");
    y++;
    x++;
}
