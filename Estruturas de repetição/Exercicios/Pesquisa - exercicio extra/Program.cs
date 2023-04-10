int i = 0;

int homemSim = 0;
int mulherSim = 0;

int homemNao = 0;
int mulherNao = 0;

char sexo;
char resposta;


while (i < 10)
{
    Console.WriteLine($"Está sastifeito com o produto da empresa ? (s para sim e n para não)");
    resposta = char.Parse(Console.ReadLine().ToLower());
    switch (resposta)
    {
        case 's':
            Console.WriteLine($"Qual o seu sexo? (m para masculino ou f para feminino)");
            sexo = char.Parse(Console.ReadLine());
            if (sexo == 'm')
            {
                homemSim++;
            }
            else
            {
                mulherSim++;
            }
            break;
        case 'n':
            Console.WriteLine($"Qual o seu sexo? (m para masculino ou f para feminino)");
            sexo = char.Parse(Console.ReadLine());
            if (sexo == 'm')
            {
                homemNao++;
            }
            else
            {
                mulherNao++;
            }
            break;
    }
    i++;
}
double totalH = (homemSim + homemNao);
double porcentagem = Math.Round(((homemNao / totalH ) * 100),2);

Console.WriteLine($"O total de pessoas que responderam 'sim' foram {homemSim + mulherSim}");

Console.WriteLine($"O total de pessoas que responderam 'não' foram {homemNao + mulherNao}");

Console.WriteLine($"O número de mulheres que responderam 'sim' foram {mulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam 'não' foi de {porcentagem}%");

Console.WriteLine($"Os homens analisados foram {homemSim + homemNao}");




