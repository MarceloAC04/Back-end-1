using System.Globalization;

char produto;
int quantidade;
float precoUnitario;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
------------------------------------
|     PRODUTOS            PREÇO    |
|  'd' - Doritos          R$ 4,25  |
|  'c' - Coca-Cola 1l     R$ 5,00  |
|  'm' - Melancia         R$ 3,50  |
|  'v' - Vassoura         R$ 6,50  |
------------------------------------
");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Qual é o produto?");
Console.ResetColor();
produto = char.Parse(Console.ReadLine());
produto = char.ToLower(produto);

while (produto != 'd' && produto != 'c' && produto != 'm' && produto != 'v')
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe um produto valido");
    Console.ResetColor();
    produto = char.Parse(Console.ReadLine());
}
switch (produto)
{
    case 'd':
        break;
    case 'c':
        break;
    case 'm':
        break;
    case 'v':
        break;
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Qual é a quantidade?");
Console.ResetColor();
quantidade = int.Parse(Console.ReadLine());

while (quantidade < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe a quantidade valida");
    Console.ResetColor();
    quantidade = int.Parse(Console.ReadLine());
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Qual é o preço do produto?");
Console.ResetColor();
precoUnitario = float.Parse(Console.ReadLine());

while (precoUnitario < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Informe um preço valído");
    Console.ResetColor();
    precoUnitario = float.Parse(Console.ReadLine());
}

float totalPreco = (quantidade * precoUnitario);
double totalPagar;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"O preço total é {totalPreco.ToString("C", new CultureInfo("pt-BR"))}");
Console.ResetColor();

if (quantidade <= 5)
{
    totalPagar = Math.Round((totalPreco - (totalPreco * 0.02f)),2);
}
else if (quantidade > 5 && quantidade <= 10)
{
    totalPagar = Math.Round((totalPreco - (totalPreco * 0.03f)),2);
}
else
{
    totalPagar = Math.Round((totalPreco - (totalPreco * 0.05f)),2);
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"O total á pagar é {totalPagar.ToString("C", new CultureInfo("pt-BR"))}");
Console.ResetColor();




