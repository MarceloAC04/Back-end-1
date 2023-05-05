using Back_end_1.POO.caféTabajara;

MaquinaCafe cafezin = new MaquinaCafe();

bool desligar = true;

Console.WriteLine($"Qual a quantidade de açucar na máquina?");
cafezin.acucarDisponivel = float.Parse(Console.ReadLine());

do
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(@$"
    -----------------------------------
    | Super CafeteiraTabajaras Plus++ |
    | 1-FazerCafe                     |
    | 2-FazerCafe Padrão              |
    | 3-Açúcar disponível             |
    | 0-Desligar                      |
    ----------------------------------
    ");
    Console.ResetColor();
    Console.WriteLine($"Escolha uma opção");
    string menu = Console.ReadLine();
    switch (menu)
    {
        case "0":
        desligar = false;
        cafezin.BarraCarregamento($"Desligando",4,450);
            break;
        case "1":
        cafezin.FazerCafe(cafezin.acucarDisponivel);
            break;
        case "2":
        cafezin.FazerCafe();
            break;
        case "3":
        cafezin.acucarMaquina();
            break;
        default:
        Console.WriteLine($"Opção inválida");
        Console.ReadKey();
            break;
    }
} while (desligar);