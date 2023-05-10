using System.Globalization;
using ConversorMoedas;

string menu;

do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
------------------------
|        CAMBIO        |
| 1 - Real para Dólar  |
| 2 - Dólar para Real  |
| 0 - Sair             |
------------------------
");
    Console.ResetColor();
    Console.WriteLine($"Escolha uma opção");
    menu = Console.ReadLine();
    switch (menu)
    {
        case "1":
            Console.WriteLine($"Digite o valor que queira converter de real para dólar");
            float cambioDolar = float.Parse(Console.ReadLine());
            while (cambioDolar < 0)
            {
                Console.WriteLine($"Digite um valor válido");
                cambioDolar = float.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O valor convertido é {Cambio.RealParaDolar(cambioDolar)}");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.WriteLine($"Digite o valor que queira converter de dólar para real");
            float cambioReal = float.Parse(Console.ReadLine());
            while (cambioReal < 0)
            {
                Console.WriteLine($"Digite um valor válido");
                cambioDolar = float.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O valor convertido é {Cambio.DolarParaReal(cambioReal)}");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            break;
        case "0":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"FIM");
            Console.ResetColor();
            break;
        default:
            Console.WriteLine($"Digite uma opção válida");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (menu != "0");

