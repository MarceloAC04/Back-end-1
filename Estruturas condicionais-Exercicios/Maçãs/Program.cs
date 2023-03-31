double valorCompra;
int compradas;

Console.WriteLine($"Informe o total de maçã compradas");
compradas = int.Parse(Console.ReadLine());

if (compradas >= 12)
{
    valorCompra = Math.Round((compradas * 0.25f),2);
    Console.WriteLine($"O total da compra foi de R$ {valorCompra}");
}
else
{
    valorCompra = Math.Round((compradas * 0.30f),2);
    Console.WriteLine($"O total da compra foi de R$ {valorCompra}");
}

