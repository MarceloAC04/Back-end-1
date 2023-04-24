using calculadora;

string sair;

Calculadora calc = new Calculadora();
Console.WriteLine($"Seja Bem-vindo!");

do
{
    Console.WriteLine($"Digite o primeiro número");
    float n1 = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite o segundo número");
    float n2 = float.Parse(Console.ReadLine());

    Console.WriteLine($@"
    --------------------------
    |         MENU           |
    | 1 - Somar              |
    | 2 - Subatrair          |
    | 3 - Dividir            |
    | 4 - Multiplicar        |
    --------------------------
    ");
    Console.WriteLine($"Digite uma opção");
    string menu = Console.ReadLine();
    switch (menu)
    {
        case "1":
            Console.WriteLine($"O resultado da soma é {calc.Somar(n1, n2)}");
            break;
        case "2":
            Console.WriteLine($"O resultado da subtração é {calc.Subtrair(n1, n2)}");
            break;
        case "3":
            if (n2 == 0)
            {
                Console.WriteLine($"Impossivel dividir por 0");
            }
            else
            {
                Console.WriteLine($"O resultado da divisão é {calc.Dividir(n1, n2)}");
            }
            break;
        case "4":
            Console.WriteLine($"O resultado da multiplição é {calc.Multiplicar(n1, n2)}");
            break;
        default:
            Console.WriteLine($"Digite uma opção válida");
            break;
    }
    Console.WriteLine($"Deseja sair? S/N");
    sair = Console.ReadLine().ToUpper();
    while (sair != "S" && sair != "N")
    {
        Console.WriteLine($"Digite uma opção");
        sair = Console.ReadLine().ToUpper();
    }
    switch (sair)
    {
        case "S":
            break;
        default:
            break;
    }

}
while (sair != "S");

