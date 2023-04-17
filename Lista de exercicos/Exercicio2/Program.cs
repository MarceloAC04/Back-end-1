using System.Globalization;
float total;

static float Alcool(float litros)
{
    float precoA;
    if (litros <= 20)
    {
        precoA = (litros * 4.90f);
        return (precoA) - (precoA * 0.03f);

    }
    else
    {
        precoA = (litros * 4.90f);
        return (precoA) - (precoA * 0.05f);
    }

}

static float Gasolina(float litros)
{
    float precoG;
    if (litros <= 20)
    {
        precoG = (litros * 5.30f);
        return (precoG) - (precoG * 0.04f);
    }
    else
    {
        precoG = (litros * 5.30f);
        return (precoG) - (precoG * 0.06f);
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
        total = Alcool(litros);
        Console.WriteLine($"O preço a pagar é {Math.Round(total, 2).ToString("C", new CultureInfo("pt-BR"))}");
        Console.ResetColor();
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Green;
        total = Gasolina(litros);
        Console.WriteLine($"O preço a pagar é {Math.Round(total, 2).ToString("C", new CultureInfo("pt-BR"))}");
        Console.ResetColor();
        break;
}


