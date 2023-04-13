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

Console.WriteLine($"Quantos litros foram vendidos?");
float litros = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual foi  o combustível abastecido? ( A-alcool ou G-gasolina)");
combustivel = char.Parse(Console.ReadLine());

if (combustivel == 'A')
{
    Alcool(litros);
}
else
{
    Gasolina(litros);
}




