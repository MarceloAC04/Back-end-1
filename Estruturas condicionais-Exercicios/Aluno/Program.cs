float frequencia;
const float frequenciaMinima = 0.75f;
float media;

Console.WriteLine($"Informe a frequência do aluno");
frequencia = float.Parse(Console.ReadLine());

if (frequencia < frequenciaMinima)
{
    Console.WriteLine($"Aluno reprovado");
}
else if (frequencia >= frequenciaMinima)
{
    Console.WriteLine($"Informe a média do aluno");
    media = float.Parse(Console.ReadLine());
    if (media > 3 && media < 7)
    {
        Console.WriteLine($"Aluno em recuperação");
    }
    else if (media >= 7)
    {
        Console.WriteLine($"Aluno aprovado");
    }
    else
    {
        Console.WriteLine($"Aluno reprovado");
    }
};



