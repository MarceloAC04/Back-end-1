Console.WriteLine($@"
-----------------------------------------
|        Programa Calculadora           |
|  informe a operacao que deseja efetua |
| '+' para soma                         |
| '-' para soma                         |
| '*' para soma                         |
| '/' para soma                         |
-----------------------------------------
");

char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o numero 1");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o numero 2");
float numero2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (operacao)
{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"O resultado da soma é {resultado}");
        break;
    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"O resultado da subtração é {resultado}");
        break;
    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        break;
    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"O resultado da divisão é {resultado}");
        break;
}