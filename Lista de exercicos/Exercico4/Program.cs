float[] valores = new float[10];

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Insira o {i + 1}º valor");
    valores[i] = float.Parse(Console.ReadLine());
}