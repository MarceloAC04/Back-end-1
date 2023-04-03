float pi = 3.14f;

Console.WriteLine($"Informe o raio da circunferência");
float raio = float.Parse(Console.ReadLine());

if (raio < 1)
{
    Console.WriteLine($"Não existe medida negativa ou nula");
}
else 
{
  Console.WriteLine($"O círculo tem o diametro de {2 * raio}, comprimento de {2 * pi * raio} e a área de {(raio * raio) * pi}");
};

