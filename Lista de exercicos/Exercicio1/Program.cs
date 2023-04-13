int anoAtual = DateTime.Now.Year;
int nascimento;

do
{
    Console.WriteLine($"Informe o ano de seu nascimento:");
    nascimento = int.Parse(Console.ReadLine());
} 
while (nascimento < 0);

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
