const int senhaValida = 1234;
int senhaUsuario;

Console.WriteLine($"Digite a senha de acesso");
senhaUsuario = int.Parse(Console.ReadLine());

if (senhaValida == senhaUsuario)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"ACESSO PERMITIDO! ;)");
    Console.ResetColor();
}
else 
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"ACESSO NEGADO! ;(");
    Console.ResetColor();
};

