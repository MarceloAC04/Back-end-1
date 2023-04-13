float[] valores = new float[4];

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Insira o {i + 1}º valor");
    valores[i] = float.Parse(Console.ReadLine());
}

float maior = valores.Max();
float menor = valores.Min();

Console.WriteLine($"O maior valor é {maior} e menor é {menor}");
