using CelularPOO;

Celular novoCelular = new Celular();

string menu;
string resposta;

Console.WriteLine($"Qual a cor do celular ?");
novoCelular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular ?");
novoCelular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular ?");
novoCelular.tamanho = Console.ReadLine();


 novoCelular.Ligar();

while (novoCelular.ligado)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($@"
    --------------------------
    |         MENU           |
    | 0 - Desligar           |
    | 1 - Enviar Mensagem    |
    | 2 - Fazer ligação      |
    | 3 - Ligar              |
    --------------------------
    ");
    Console.ResetColor();
    Console.WriteLine($"Digite uma opção");
    menu = Console.ReadLine();
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
        case "3":
            Console.WriteLine($"O celular já está ligado");
            break;
        default:
            Console.WriteLine($"Selecione uma opção válida");
            break;
    }
}