Console.WriteLine($"Digite o dia de seu nascimento");
int diaNascimento = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o mês de seu nascimento");
int mesNascimento = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o ano de seu nascimento");
int anoNascimento = int.Parse(Console.ReadLine());

if (diaNascimento > 31 || diaNascimento < 1)
{
    Console.WriteLine($"Dia invalido!");
}
else if (mesNascimento > 12 || mesNascimento < 1)
{
    Console.WriteLine($"Mês invalido!");
}
else if (anoNascimento > 2013 || anoNascimento < 1)
{
    Console.WriteLine($"Ano invalido!");
}
else
{
    Console.WriteLine($"Data Válida!");
}