Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
---------------------
|  Programa para    |
|  calcular média   |
---------------------
");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-Vindo! ao nosso sistema ;)");
Console.ResetColor();

Console.WriteLine($"Informe a nota1");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota2");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota3");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota4");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a nota5");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"Sua média é {media}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema");
Console.ResetColor();
