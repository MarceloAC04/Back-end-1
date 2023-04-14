string[] nomes = new string[4];

static void BarraCarregamento(string texto, int pontos, int tempo)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(texto);

    for (int i = 0; i < pontos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
    Console.WriteLine($"");
}


for (int i = 0; i < nomes.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Digite o {i + 1}º nome");
    Console.ResetColor();
    nomes[i] = Console.ReadLine();
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Informe o nome que queira verificar:");
Console.ResetColor();

string nome = Console.ReadLine();

BarraCarregamento("Procurando", 5, 700);

if (nomes.Contains(nome))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"ACHEI!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"NÃO ACHEI!");
    Console.ResetColor();
}
