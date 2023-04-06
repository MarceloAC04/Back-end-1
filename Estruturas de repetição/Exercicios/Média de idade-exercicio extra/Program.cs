int i = 0;

int homem = 0;
int mulher = 0;

int idadeH = 0;
int idadeTotalH = 0;

int idadeM = 0;
float idadeTotalM = 0;

float pesoH;
float pesoM;

string sexo;

while (i < 10)
{
    Console.WriteLine($"Qual o seu sexo?");
    sexo = Console.ReadLine();
    if (sexo == "masculino")
    {
        homem++;
        Console.WriteLine($"qual a sua idade?");
        idadeH = int.Parse(Console.ReadLine());
        idadeTotalH += idadeH;
        Console.WriteLine($"Qual o seu peso?");
        pesoH = float.Parse(Console.ReadLine());
    }
    else
    {
        mulher++;
        Console.WriteLine($"qual a sua idade?");
        idadeM = int.Parse(Console.ReadLine());
        idadeTotalM += idadeM;
        Console.WriteLine($"Qual o seu peso?");
        pesoM = float.Parse(Console.ReadLine());
    }
i++;
}

Console.WriteLine($"O total de homens é {homem}");
Console.WriteLine($"O total de mulheres é {mulher}");

float mediaH = (idadeTotalH / homem);
float mediaM = (idadeTotalM / mulher);

Console.WriteLine($"A média de idade dos homens é {mediaH} anos");
Console.WriteLine($"A média de idade das mulheres é {mediaM} anos");


