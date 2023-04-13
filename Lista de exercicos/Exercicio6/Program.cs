string[] nomes = new string[10];
bool verificado = false;

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º nome");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"Informe o nome que queira verificar:");
string nome = Console.ReadLine();

foreach (string item in nomes)
{
    if (item == nome)
    {
        verificado = true;
        break;
    }
    else
    {
        verificado = false;
    }
}

switch (verificado)
{
    case true:
        Console.WriteLine($"ACHEI");
        break;
    default:
        Console.WriteLine($"NÃO ACHEI");
        break;
}

