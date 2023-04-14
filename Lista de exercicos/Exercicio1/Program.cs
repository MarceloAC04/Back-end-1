int anoAtual = DateTime.Now.Year;
int nascimento;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Informe o ano de seu nascimento:");
Console.ResetColor();
nascimento = int.Parse(Console.ReadLine());


while (nascimento < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe um ano valido");
    Console.ResetColor();
    nascimento = int.Parse(Console.ReadLine());
}

int idade = (anoAtual - nascimento);
if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Poderá votar esse ano");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Não poderá votar esse ano");
    Console.ResetColor();
}
