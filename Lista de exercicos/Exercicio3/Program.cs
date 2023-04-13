using System.Globalization;

string produto;
int quantidade;
float precoUnitario;

Console.WriteLine($"Qual é o produto?");
produto = Console.ReadLine();

do
{
Console.WriteLine($"Qual é a quantidade?");
quantidade = int.Parse(Console.ReadLine());
    
} 
while (quantidade < 0);

do
{ 
Console.WriteLine($"Qual é o preço do produto?");
precoUnitario = float.Parse(Console.ReadLine());
} 
while (precoUnitario < 0);

float totalPreco = (quantidade * precoUnitario);
double totalPagar;

Console.WriteLine($"O preço total é {totalPreco}");
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

Console.WriteLine($"O total á pagar é {totalPagar.ToString("C", new CultureInfo("pt-BR"))}");




