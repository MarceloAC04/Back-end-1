int salario;
int gastos;

Console.WriteLine($"Informe o salario recebido");
salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gastos feitos");
gastos = int.Parse(Console.ReadLine());

if (salario < gastos)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Orçamento estourado!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Gastos dentro do orçamento ");
    Console.ResetColor();
};



