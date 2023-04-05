Console.WriteLine($"Digite o seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o seu salario");
float salario = float.Parse(Console.ReadLine());


Console.WriteLine($"Informe o seu estado civil: (digite s para solteiro(a), ou c para casado(a), ou v para viuvo(a), ou d para divorciado(a)");
char estado = char.Parse(Console.ReadLine());


while (nome.Length == 0)
{
    Console.WriteLine($"Digite o seu nome novamente");
    nome = Console.ReadLine();
}

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"Digite sua idade novamente");
    idade = int.Parse(Console.ReadLine());
}

while (salario <= 0)
{
    Console.WriteLine($"Digite o seu salario novamente");
    salario = float.Parse(Console.ReadLine());
}

while (estado != 's' && estado != 'c' && estado != 'v' && estado != 'd' )
{
    Console.WriteLine($"Informe o seu estado civil novamente");
    estado = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Informações cadastradas com sucesso!");