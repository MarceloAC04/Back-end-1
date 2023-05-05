using ElevadorPOO.Classes;

Elevador elevador = new Elevador();

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

bool desligar = true;

Console.WriteLine($"Qual é a capacidade do elevador");
elevador.capacidade = int.Parse(Console.ReadLine());
Console.WriteLine($"Quantos andares o prédio");
elevador.totalAndares = int.Parse(Console.ReadLine());

elevador.Inicializar(elevador.capacidade, elevador.totalAndares);
do
{
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
---------------------------------------
|         Elevador Tabajara           |
|    4-Subir         5-Descer         |
|                                     |
|    2-Entrar        3-Sair           |
|                                     |
|    0-Desligar      1-info           |
---------------------------------------
");
Console.ResetColor();
Console.WriteLine($"Escolha uma opção");
string menu = Console.ReadLine();

switch (menu)
{
    case "0":
    desligar = false;
    BarraCarregamento("Desligando",6,700);
        break;
    case "1":
    elevador.Info();
    Console.Clear();
        break;
    case "2":
    elevador.Entrar();
    Console.Clear();
        break;
    case "3":
    elevador.Sair();
    Console.Clear();
        break;
    case "4":
    elevador.Subir();
    Console.Clear();
        break;
    case "5":
    elevador.Descer();
    Console.Clear();
        break;
    default:
    Console.WriteLine($"Selecione uma opção válida!");
    Console.ReadKey();
    Console.Clear();
        break;
}
} while (desligar);



