int i = 0;

int homemSim = 0;
int mulherSim = 0;

int homemNao = 0;
int mulherNao = 0;

string sexo;
string resposta;

while (i < 10)
{
    Console.WriteLine($"Está sastifeito com o produto da empresa ? (sim ou não)");
    resposta = Console.ReadLine().ToLower();
    switch (resposta)
    {
        case "sim":
            Console.WriteLine($"Qual o seu sexo? (masculino ou feminino)");
            sexo = Console.ReadLine();
            if (sexo == "masculino")
            {
                homemSim++;
            }
            else
            {
                mulherSim++;
            }
            break;
        case "não":
            Console.WriteLine($"Qual o seu sexo? (masculino ou feminino)");
            sexo = Console.ReadLine();
            if (sexo == "masculino")
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
float total = (homemSim + mulherSim) + (mulherNao + homemNao);
float porcentagem = (homemNao / total) * 100;

Console.WriteLine($"O total de pessoas que responderam 'sim' foram {homemSim + mulherSim}");

Console.WriteLine($"O total de pessoas que responderam 'não' foram {homemNao + mulherNao}");

Console.WriteLine($"O número de mulheres que responderam 'sim' foram {mulherSim}");

Console.WriteLine($"A porcentagem de homens que responderam 'não' foi de {porcentagem}%");

Console.WriteLine($"Os homens analisados foram {homemSim + homemNao}");




