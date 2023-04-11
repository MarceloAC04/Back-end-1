int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($" ");

foreach (int item in numeros)
{
    Console.WriteLine($"O dobro de {item} é {item * 2}");
}
