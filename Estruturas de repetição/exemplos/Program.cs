﻿// bool idadeCerta = false;

// while (idadeCerta == false)
// {
//     Console.WriteLine($"Qual a idade do pericles ?");
//     int idade = int.Parse(Console.ReadLine());

//     if (idade == 53)
//     {
//      idadeCerta = true;
//     }
    
// }

Console.WriteLine($"Digite o seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha (tem que ter 6 caracteres)");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Digite a senha novamente no padrão requerido (com 6 caracteres)");
     senha = Console.ReadLine();
}

Console.WriteLine($"Usuário e senha recebidos com sucesso!");



