int nivelSuspeito = 0;

Console.WriteLine($"Telefonou para a vítima?");
string resposta = Console.ReadLine().ToLower();
if (resposta == "sim")
{
    nivelSuspeito++;
}

Console.WriteLine($"Esteve no local do crime?");
string resposta2 = Console.ReadLine().ToLower();
if (resposta2 == "sim")
{
    nivelSuspeito++;
}

Console.WriteLine($"Mora perto da vítima?");
string resposta3 = Console.ReadLine().ToLower();
if (resposta3 == "sim")
{
    nivelSuspeito++;
}

Console.WriteLine($"Devia para a vítima?");
string resposta4 = Console.ReadLine().ToLower();
if (resposta4 == "sim")
{
    nivelSuspeito++;
}

Console.WriteLine($"Já trabalhou com a vítima?");
string resposta5 = Console.ReadLine().ToLower();
if (resposta5 == "sim")
{
    nivelSuspeito++;
}


if (nivelSuspeito == 2)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Indivíduo é suspeito");
    Console.ResetColor();
}
else if (nivelSuspeito >=3 && nivelSuspeito <=4)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"Indivíduo é cúmplice!");
    Console.ResetColor();
}
else if (nivelSuspeito == 5)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Indivíduo é culpado!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Indivíduo é inocente!");
    Console.ResetColor();
};