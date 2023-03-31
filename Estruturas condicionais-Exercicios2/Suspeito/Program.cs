int nivelSuspeito = 0;

Console.WriteLine($"Telefonou para a vítima?");
string resposta = Console.ReadLine();
if (resposta == "sim")
{
    nivelSuspeito++;
}
else if (resposta == "não")
{
    nivelSuspeito = nivelSuspeito;
};

Console.WriteLine($"Esteve no local do crime?");
string resposta2 = Console.ReadLine();
if (resposta2 == "sim")
{
    nivelSuspeito++;
}
else if (resposta2 == "não")
{
    nivelSuspeito = nivelSuspeito;

};

Console.WriteLine($"Mora perto da vítima?");
string resposta3 = Console.ReadLine();
if (resposta3 == "sim")
{
    nivelSuspeito++;
}
else if (resposta3 == "não")
{
    nivelSuspeito = nivelSuspeito;
};

Console.WriteLine($"Devia para a vítima?");
string resposta4 = Console.ReadLine();
if (resposta4 == "sim")
{
    nivelSuspeito++;
}
else if (resposta4 == "não")
{
    nivelSuspeito = nivelSuspeito;
};

Console.WriteLine($"Já trabalhou com a vítima?");
string resposta5 = Console.ReadLine();
if (resposta5 == "sim")
{
    nivelSuspeito++;
}
else if (resposta5 == "não")
{
    nivelSuspeito = nivelSuspeito;
};

if (nivelSuspeito == 2)
{
    Console.WriteLine($"Indivíduo é suspeito");
    
}
else if (nivelSuspeito >=3 && nivelSuspeito <=4)
{
    Console.WriteLine($"Indivíduo é cúmplice!");
}
else if (nivelSuspeito == 5)
{
    Console.WriteLine($"Indivíduo é culpado!");
}
else
{
    Console.WriteLine($"Indivíduo é inocente!");
};