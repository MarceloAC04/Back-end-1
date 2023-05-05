using Back_end_1.POO.Jogador.Classes;

Atacante ataque = new Atacante();
Zagueiro zaga = new Zagueiro();
MeioCampista meia = new MeioCampista();

bool desligar = true;
bool novo = true;

do
{
    Console.WriteLine($"Qual o nome do jogador ?");
    string nomeJogador = Console.ReadLine();
    ataque.nome = nomeJogador;
    zaga.nome = nomeJogador;
    meia.nome = nomeJogador;

    Console.WriteLine($"Qual o ano de nascimento do jogador  ?");
    int dataJogador = int.Parse(Console.ReadLine());
    ataque.dataNascimento = dataJogador;
    zaga.dataNascimento = dataJogador;
    meia.dataNascimento = dataJogador;

    Console.WriteLine($"Qual a nacionaliade do jogador ?");
    string nacionalJogador = Console.ReadLine();
    ataque.nacionalidade = nacionalJogador;
    zaga.nacionalidade = nacionalJogador;
    meia.nacionalidade = nacionalJogador;

    Console.WriteLine($"Qual o peso do jogador ?");
    float pesoJogador = float.Parse(Console.ReadLine());
    ataque.peso = pesoJogador;
    zaga.peso = pesoJogador;
    meia.peso = pesoJogador;

    Console.WriteLine($"Qual a altura do jogador ?");
    float alturaJogador = float.Parse(Console.ReadLine());
    ataque.altura = alturaJogador;
    zaga.altura = alturaJogador;
    meia.altura = alturaJogador;
    while (novo && desligar)
    {
        Console.WriteLine(@$"
    --------------------------------
    |             BID              |         
    |  0 - Sair                    |           
    |  1 - Novo Jogador            |
    |  2 - Perfil                  |
    |  3 - Idade\Aposentadoria     |
    -------------------------- -----   
    ");
        Console.WriteLine($"Escolha uma opção");
        string menu = Console.ReadLine();
        switch (menu)
        {
            case "0":
                desligar = false;
                Console.WriteLine($"Saindo");
                break;
            case "1":
                novo = false;
                Console.WriteLine($"Abrindo novo registro");
                Console.Clear();
                break;
            case "2":
                meia.Perfil();
                break;
            case "3":
                Console.WriteLine(@$"Qual a posição o jogador joga?
                          (Z)zaga - (M)Meio de Campo - (A) Ataque");
                Console.WriteLine($"Selecione uma posição");      
                string resposta = Console.ReadLine().ToUpper();
                switch (resposta)
                {
                    case "Z":
                    zaga.IdadeJogador();
                    zaga.Aposetadoria();
                        break;
                    case "M":
                    meia.IdadeJogador();
                    meia.Aposetadoria();
                        break;
                    case "A":
                    ataque.IdadeJogador();
                    ataque.Aposetadoria();
                        break;
                    default:
                        Console.WriteLine($"Selecione uma opção válida");
                        Console.WriteLine($"Aperte enter para sair");
                        Console.ReadKey();
                        break;
                }
                break;
            default:
                Console.WriteLine($"Selecione uma opção válida");
                Console.WriteLine($"Aperte enter para sair");
                Console.ReadKey();
                break;
        }
    }
} while (desligar);