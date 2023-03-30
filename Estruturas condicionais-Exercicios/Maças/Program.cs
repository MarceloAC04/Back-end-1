float valorCompra;
int compradas;

Console.WriteLine($"Informe o total de maçã compradas");
compradas = int.Parse(Console.ReadLine());

if (compradas >= 12)
{
    valorCompra = (compradas * 0.25f);
    Console.WriteLine($"O total da compra foi de R$ {valorCompra}");
}
else
{
    valorCompra = (compradas * 0.30f);
    Console.WriteLine($"O total da compra foi de R$ {valorCompra}");
}

