string[] nome = new string[2];
float[] preco = new float[2];
bool[] promocao = new bool[2];
string[] promo = new string[2];
char respostaPromo;
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

string[] CadastroNome(int i)
{
    Console.WriteLine($"Digite o nome do produto");
    nome[i] = Console.ReadLine();

    return nome;
}

float[] CadastroPreco(int i)
{
    do
    {
        Console.WriteLine($"informe o preço do produto (informe corretamente)");
        preco[i] = float.Parse(Console.ReadLine());
    } while (preco[i] <= 0);
    return preco;
}

bool[] CadastroPromocao(int i)
{
    do
    {
        Console.WriteLine($"O produto está em promoção? S/N (informe corretamente)");
        respostaPromo = char.Parse(Console.ReadLine());
        respostaPromo = char.ToUpper(respostaPromo);
    } while (respostaPromo != 'N' && respostaPromo != 'S');
    if (respostaPromo == 'S')
    {
        promocao[i] = true;
    }
    else
    {
        promocao[i] = false;
    }
    return promocao;
}

void listarProduto(int i)
{
    Console.WriteLine($"Os produtos cadastrados são");
    Console.WriteLine($"{i + 1}º produto");
    Console.WriteLine($"Produto: {nome[i]}");
    Console.WriteLine($"Preço: {preco[i]}");
    Console.WriteLine(promocao[i] == true ? "Em promoção" : "Não está em promoção");
    Console.WriteLine($"");
}


// BarraCarregamento("Entrando no sistema", 7, 700);
while (sair)
{
    Console.WriteLine($@"
           Bem-Vindo!
    --------------------------
    |        MENU            |
    | 1 - Cadastrar Produto  |
    | 2 - Listar Produtos    |
    | 3 - Mostrar Menu       |
    | 0- Sair                |
    --------------------------
    ");
    Console.WriteLine($"Digite uma opção");
    int menu = int.Parse(Console.ReadLine());
    while (menu != 0 && menu != 1 && menu != 2 && menu != 3)
    {
        Console.WriteLine($"Digite uma opção válida");
        menu = int.Parse(Console.ReadLine());
    }
    switch (menu)
    {
        case 0:
            sair = false;
            // BarraCarregamento("Saindo do sistema", 7, 700);
            break;
        case 1:
            for (int i = 0; i < nome.Length; i++)
            {
                CadastroNome(i);
                CadastroPreco(i);
                CadastroPromocao(i);
                Console.WriteLine($"Gostaria de cadastrar outra passagem? S/N");
                char resposta = char.Parse(Console.ReadLine());
                resposta = char.ToUpper(resposta);
                while (resposta != 'N' && resposta != 'S')
                {
                    Console.WriteLine($"Informe o comando corretament S/N");
                    resposta = char.Parse(Console.ReadLine());
                    resposta = char.ToUpper(resposta);
                }
                switch (resposta)
                {
                    case 'N':
                        i = nome.Length;
                        break;
                    default:
                        continue;
                }
            }
            Console.WriteLine($"Produto cadastrado!");
            // BarraCarregamento("Saindo",7,700);
            break;
        case 2:
            for (int i = 0; i < nome.Length; i++)
            {
                listarProduto(i);
            }
            int listaResposta = int.Parse(Console.ReadLine());
            while (listaResposta != 3)
            {
                Console.WriteLine($"Digite o comando corretamente para sair");
                listaResposta = int.Parse(Console.ReadLine());
            }
            break;
    }
}