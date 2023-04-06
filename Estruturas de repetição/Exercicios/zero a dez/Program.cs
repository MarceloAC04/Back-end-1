Console.WriteLine($"Informe a nota: 0 a 10");
float nota = float.Parse(Console.ReadLine());

while(nota < 0 || nota > 10)
{
    Console.WriteLine($"Informe uma nota valida de 0 a 10");
    nota = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Nota valida!");

