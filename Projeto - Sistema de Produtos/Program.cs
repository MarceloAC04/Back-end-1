string[] nome = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];
string[] promo = new string[10];
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
    Console.WriteLine($"{i + 1}º produto");
    Console.WriteLine($"Produto: {nome[i]}");
    Console.WriteLine($"Preço: R$ {preco[i]}");
    Console.WriteLine($"Em promoção: {(promocao[i] == true ? "SIM" : "NÃO")}");
    Console.WriteLine($"");
}

void MostrarMenu()
{
    for (int i = 0; i < nome.Length; i++)
    {
        Console.WriteLine($" {nome[i]}    R$ {preco[i]}      {(promocao[i] == true ? "SIM" : "NÃO")}");

    }
}

BarraCarregamento("Entrando no sistema", 7, 700);
while (sair)
{
    Console.WriteLine($@"
           Bem-Vindo!
    --------------------------
    |         MENU           |
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
            BarraCarregamento("Saindo do sistema", 7, 700);
            break;
        case 1:
            char resposta;
            do
            {
                for (int i = 0; i < nome.Length; i++)
                {
                    CadastroNome(i);
                    CadastroPreco(i);
                    CadastroPromocao(i);
                    Console.WriteLine($"Produto cadastrado!");
                }
                Console.WriteLine($"Gostaria de registrar outro produto? S/N");

                resposta = char.Parse(Console.ReadLine());
                resposta = char.ToUpper(resposta);
                while (resposta != 'N' && resposta != 'S')
                {
                    Console.WriteLine($"Informe o comando corretament S/N");
                    resposta = char.Parse(Console.ReadLine());
                    resposta = char.ToUpper(resposta);
                }
            } while (resposta == 'S');
            BarraCarregamento("Saindo", 5, 500);
            break;
        case 2:
            Console.WriteLine($"Os produtos cadastrados são");
            for (int i = 0; i < nome.Length; i++)
            {
                listarProduto(i);
            }
            Console.WriteLine($"Digite ok para sair");
            string listaResposta = Console.ReadLine().ToLower();
            while (listaResposta != "ok")
            {
                Console.WriteLine($"Digite o comando corretamente para sair");
                listaResposta = Console.ReadLine().ToLower();
            }
            BarraCarregamento("Saindo", 5, 500);
            break;
        case 3:
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"      Mercadinho Tabajara            ");
            Console.WriteLine($" Nome       Preço      Promoção      ");
            MostrarMenu();
            Console.WriteLine($"-------------------------------------");

            Console.WriteLine($"Digite ok para sair");
            string menuResposta = Console.ReadLine().ToLower();
            while (menuResposta != "ok")
            {
                Console.WriteLine($"Digite o comando corretamente para sair");
                listaResposta = Console.ReadLine().ToLower();
            }
            BarraCarregamento("Saindo", 5, 500);
            break;
    }
}