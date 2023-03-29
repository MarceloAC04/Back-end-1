Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
---------------------
|  Programa para    |
|  calcular idade   |
---------------------
");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bem-Vindo! ao nosso sistema ;)");
Console.ResetColor();




Console.WriteLine($"Informe sua idade");
int idade = int.Parse(Console.ReadLine());

int meses = (idade * 12);

int dias = (idade * 365);

int horas = (dias * 24);

int minutos = (horas * 60);

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@$"Sua idade aproximadamnete em
meses: {meses}
dias: {dias}
horas: {horas}
minutos: {minutos}
");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Obrigado por utilizar nosso sistema");
Console.ResetColor();

