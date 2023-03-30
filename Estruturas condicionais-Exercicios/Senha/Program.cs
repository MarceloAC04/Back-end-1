const int senhaValida = 1234;
int senhaUsuario;

Console.WriteLine($"Digite a senha de acesso");
senhaUsuario = int.Parse(Console.ReadLine());

if (senhaValida == senhaUsuario)
{
    Console.WriteLine($"ACESSO PERMITIDO! ;)");
}
else 
{
    Console.WriteLine($"ACESSO NEGADO! ;(");
}

