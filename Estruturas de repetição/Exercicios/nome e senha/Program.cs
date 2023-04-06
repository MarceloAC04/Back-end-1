Console.WriteLine($"Digite o nome do usuario");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a sua senha");
string senha = Console.ReadLine();

while( nome == senha)
{
    Console.WriteLine($"ERRO");
    Console.WriteLine($"Digite seu nome novamente");
    nome = Console.ReadLine();
    Console.WriteLine($"Digite a senha novamente");
    senha = Console.ReadLine();
}

Console.WriteLine($"informações cadastradas");


