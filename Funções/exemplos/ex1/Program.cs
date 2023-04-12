// static void Saudacao()
// {
//     Console.WriteLine($"Informe o nome da pessoa");
//     string nome = Console.ReadLine();
//     Console.WriteLine($"Informe o sobrenome da pessoa");
//     string sobrenome = Console.ReadLine();
//     Console.WriteLine($"Bom dia! {nome} {sobrenome}");
    
// }

// Saudacao();

static float Somar(float n1, float n2)
{
    return (n1 + n2);
}
static float Subtrair(float n1, float n2)
{
    return (n1 - n2);
}
static float Dividir(float n1, float n2)
{
    return (n1 / n2);
}
static float Multiplicar(float n1, float n2)
{
    return (n1 * n2);
}

Console.WriteLine($"Informe o primeiro numero");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero");
float n2 = float.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"A soma de {n1} + {n2} é {Somar(n1,n2)} ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"A subtração de {n1} - {n2} é {Subtrair(n1,n2)} ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"A divisão de {n1} / {n2} é {Dividir(n1,n2)} ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"A multiplicação de {n1} x {n2} é {Multiplicar(n1,n2)} ");
Console.ResetColor();