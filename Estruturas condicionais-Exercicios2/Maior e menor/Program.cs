float maior;
float menor;

Console.WriteLine($"Digite o número 1");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o número 2");
float numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o número 3");
float numero3 = float.Parse(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3)
{
    maior = numero1;
    if (numero2 > numero3)
    {
      menor = numero3;   
    }
    else 
    {
        menor = numero2;
    }
    Console.WriteLine($"O maior é {maior} e o menor é {menor}");
    
}
else if (numero2 > numero1 && numero2 > numero3)
{
    maior = numero2;
    if (numero1 > numero3)
    {
      menor = numero3;   
    }
    else 
    {
        menor = numero1;
    }
    Console.WriteLine($"O maior é {maior} e o menor é {menor}");
}
else 
{
    maior = numero3;
     if (numero1 > numero2)
    {
      menor = numero2;   
    }
    else 
    {
        menor = numero1;
    }
    Console.WriteLine($"O maior é {maior} e o menor é {menor}");
};