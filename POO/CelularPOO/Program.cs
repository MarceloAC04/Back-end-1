using CelularPOO;

Celular novoCelular = new Celular();

Console.WriteLine($"Qual a cor do celular ?");
novoCelular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular ?");
novoCelular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular ?");
novoCelular.tamanho = Console.ReadLine();

do
{
    novoCelular.Ligar();
    if (novoCelular.ligado == false)
    {
        break;
    }
    while (novoCelular.ligado)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($@"
    --------------------------
    |         MENU           |
    | 0 - Desligar           |
    | 1 - Enviar Mensagem    |
    | 2 - Fazer ligação      |
    --------------------------
    ");
        Console.ResetColor();
        Console.WriteLine($"Digite uma opção");
        string menu = Console.ReadLine();
        switch (menu)
        {
            case "0":
                novoCelular.Desligar();
                break;
            case "1":
                novoCelular.EnviarMensagem();
                break;
            case "2":
                novoCelular.FazerLigacao();
                break;
            default:
                Console.WriteLine($"Selecione uma opção válida");
                break;
        }

    }
} while (novoCelular.ligado != true);