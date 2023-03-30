int salario;
int gastos;

Console.WriteLine($"Informe o salario recebido");
salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe os gastos feitos");
gastos = int.Parse(Console.ReadLine());

if (salario < gastos)
{
    Console.WriteLine($"Orçamento estourado");
}
else
{
    Console.WriteLine($"Gastos dentro do orçamento ");
    
};



