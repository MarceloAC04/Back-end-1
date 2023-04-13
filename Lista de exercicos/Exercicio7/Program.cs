float[] numeros = new float[15];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    numeros[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine($"Ordem inversa");
Array.Reverse(numeros);
foreach (float item in numeros)
{
    Console.WriteLine($"{item}");
    
}
