const string senhaValida = "123456";
string[] passageiro = new string[2];
string[] origem = new string[2];
string[] destino = new string[2];
string[] data = new string[2];
string senha;
bool sair = true;

static void BarraCarregamento(string texto, int pontos, int tempo)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(texto);

    for (int i = 0; i < pontos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
    Console.WriteLine($"");
}

static bool login(string senha)
{
    bool valida;
    if (senha == senhaValida)
    {
        valida = true;
    }
    else
    {
        valida = false;
    }
    return valida;
}

string[] passagem()
{
    do
    {
        char resposta;
        for (int i = 0; i < passageiro.Length; i++)
        {
            Console.WriteLine($"Digite o nome do passageiro");
            passageiro[i] = Console.ReadLine();

            Console.WriteLine($"informe a origem do voo");
            origem[i] = Console.ReadLine();

            Console.WriteLine($"informe o destino do voo");
            destino[i] = Console.ReadLine();

            Console.WriteLine($"Digite a data do voo");
            data[i] = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Passagem cadastrada");
            Console.ResetColor();
        }

        Console.WriteLine($"Gostaria de cadastrar outra passagem? S/N");
        resposta = char.Parse(Console.ReadLine());
        resposta = char.ToUpper(resposta);
        while (resposta != 'N' && resposta != 'S')
        {
            Console.WriteLine($"Informe o comando corretament S/N");
            resposta = char.Parse(Console.ReadLine());
            resposta = char.ToUpper(resposta);
        }
    } while (resposta == 'S');

    return passageiro;
    return origem;
    return destino;
    return data;
}

void listar()
{
    Console.WriteLine($"As passagens cadastradas são");
    for (int i = 0; i < passageiro.Length; i++)
    {
        Console.WriteLine($"{i + 1}º passagem");
        Console.WriteLine($"Passageiro: {passageiro[i]}");
        Console.WriteLine($"Origem e Destino: {origem[i]} e {destino[i]}");
        Console.WriteLine($"Data: {data[i]}");
        Console.WriteLine($"");

    }
    Console.WriteLine($"Digite ok para sair");
    string listaResposta = Console.ReadLine().ToLower();
    while (listaResposta != "ok")
    {
        Console.WriteLine($"Digite o comando corretamente para sair");
        listaResposta = Console.ReadLine().ToLower();
    }
    BarraCarregamento("Saindo", 7, 700);
}

Console.WriteLine($"Digite a senha de login");
senha = Console.ReadLine();
switch (login(senha))
{
    case true:
        break;
    default:
        do
        {
            Console.WriteLine($"Digite a senha correta");
            senha = Console.ReadLine();
        } while (login(senha) == false);
        break;
}

Console.WriteLine($"Usuario cadastrado!");
BarraCarregamento("Entrando no sistema", 7, 700);
while (sair)
{
    Console.WriteLine($@"
           Bem-Vindo!
    --------------------------
    |        MENU            |
    | 1- Cadastrar passagem  |
    | 2- Listar Passagens    |
    | 0- Sair                |
    --------------------------
    ");
    Console.WriteLine($"Digite uma opção");
    int menu = int.Parse(Console.ReadLine());
    while (menu != 0 && menu != 1 && menu != 2)
    {
        Console.WriteLine($"Digite uma opção válida");
        menu = int.Parse(Console.ReadLine());
    }
    switch (menu)
    {
        case 0:
            sair = false;
            BarraCarregamento("Saindo do sistema", 7, 700);
            break;
        case 1:
            passagem();
            BarraCarregamento("Saindo", 7, 700);
            break;
        case 2:
            listar();
            break;
    }
}


