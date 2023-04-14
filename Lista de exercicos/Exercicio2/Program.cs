using System.Globalization;

static void Alcool(float litros)
{
    switch (litros)
    {
        case <= 20:
            float precoA = (litros * 4.90f);
            Console.WriteLine($"O preço a pagar é {Math.Round((precoA) - (precoA * 0.03), 2).ToString("C", new CultureInfo("pt-BR"))}");
            break;
        default:
            precoA = (litros * 4.90f);
            Console.WriteLine($"O preço a pagar é {Math.Round((precoA) - (precoA * 0.05), 2).ToString("C", new CultureInfo("pt-BR"))}");
            break;
    }

}

static void Gasolina(float litros)
{
    switch (litros)
    {
        case <= 20:
            float precoG = (litros * 5.30f);
            Console.WriteLine($"O preço a pagar é {Math.Round((precoG) - (precoG * 0.04), 2).ToString("C", new CultureInfo("pt-BR"))}");
            break;
        default:
            precoG = (litros * 5.30f);
            Console.WriteLine($"O preço a pagar é {Math.Round((precoG) - (precoG * 0.06), 2).ToString("C", new CultureInfo("pt-BR"))}");
            break;
    }

}

char combustivel;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Quantos litros foram vendidos?");
Console.ResetColor();
float litros = float.Parse(Console.ReadLine());

while (litros <= 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe corretamente a quantidade de litros vendidos");
    Console.ResetColor();
    litros = float.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Qual foi  o combustível abastecido? ((A) para alcool ou (G) para gasolina)");
Console.ResetColor();
combustivel = char.Parse(Console.ReadLine());
combustivel = char.ToUpper(combustivel);

while (combustivel != 'A' && combustivel != 'G')
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe corretamente o tipo de combustivel");
    Console.ResetColor();
    combustivel = char.Parse(Console.ReadLine());
}

switch (combustivel)
{
    case 'A':
        Console.ForegroundColor = ConsoleColor.Green;
        Alcool(litros);
        Console.ResetColor();
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Green;
        Gasolina(litros);
        Console.ResetColor();
        break;
}


