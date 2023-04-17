const int senhaValida = 123456;
string[] passageiro = new string[2];
string[] origemDestino = new string[2];
string[] data = new string[2];
int senha;
bool sair = true;

static bool login(int senha)
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

Console.WriteLine($"Digite a senha de login");
senha = int.Parse(Console.ReadLine());
switch (login(senha))
{
    case true:
        break;
    default:
        do
        {
            Console.WriteLine($"Digite a senha correta");
            senha = int.Parse(Console.ReadLine());
        } while (login(senha) == false);
        break;
}

Console.WriteLine($"Usuario cadastrado");
while (sair)
{
    Console.WriteLine($@"
    --------------------------
    |        MENU            |
    | 1- Cadastrar passagem  |
    | 2- Listar Passagens    |
    | 0- Sair                |
    --------------------------
    ");
    Console.WriteLine($"Digite uma opção");
    int menu = int.Parse(Console.ReadLine());
    switch (menu)
    {
        case 0:
            sair = false;
            break;
        case 1:
            for (int i = 0; i < passageiro.Length; i++)
            {
                Console.WriteLine($"Digite o nome do passageiro");
                passageiro[i] = Console.ReadLine();
                Console.WriteLine($"informe a origem e destino do voo");
                origemDestino[i] = Console.ReadLine();
                Console.WriteLine($"Digite a data do voo");
                data[i] = Console.ReadLine();

                Console.WriteLine($"Gostaria de cadastrar outra passagem?");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'N')
                {
                    break;
                }
                else
                {
                    i = i;
                }
            }
            break;
        case 2:
        for (int i = 0; i < passageiro.Length; i++)
        {
            Console.WriteLine($"{i + 1}º passagem");
            Console.WriteLine($"Passageiro: {passageiro[i]}");
            Console.WriteLine($"Origem e Destino: {origemDestino[i]}");
            Console.WriteLine($"Data: {data[i]}");
        }
            break;
    }
}


