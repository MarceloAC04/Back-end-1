Console.WriteLine($@"
-----------------------------------------
|           Programa Bebidas            |
|  informe o tipo de bebida que deseja  |
| 1 para café expresso                  |
| 2 para suco de laranja                |
| 3 para coca-cola                      |
| 4 para água                           |
| 5 para chá mate                       |
-----------------------------------------
");

int bebida = int.Parse(Console.ReadLine());
string gelo;

switch (bebida)
{
    case 1:
    Console.WriteLine($"Saindo um café expresso");
    break;

    case 2:
    Console.WriteLine($"Gostaria de adicionar gelo ao seu pedido?: sim ou nâo");
     gelo = Console.ReadLine().ToLower();
    if (gelo == "sim")
    {
        Console.WriteLine($"Saindo um suco de laranja com gelo adicional");
    }
    else 
    {
        Console.WriteLine($"Saindo um suco de laranja sem gelo adicional");
    }
    break;

    case 3:
    Console.WriteLine($"Gostaria de adicionar gelo ao seu pedido?: sim ou nâo");
    gelo= Console.ReadLine().ToLower();
    if (gelo== "sim")
    {
        Console.WriteLine($"Saindo uma coca-cola com gelo adicional");
    }
    else 
    {
        Console.WriteLine($"Saindo uma coca-cola sem gelo adicional");
    }
    break;

    case 4:
    Console.WriteLine($"Gostaria de adicionar gelo ao seu pedido?: sim ou nâo");
    gelo = Console.ReadLine().ToLower();
    if (gelo == "sim")
    {
        Console.WriteLine($"Saindo uma água com gelo adicional");
    }
    else 
    {
        Console.WriteLine($"Saindo uma água sem gelo adiconal");
    }
    break;

    case 5:
    Console.WriteLine($"Saindo um chá mate");
    break;

    default :
    Console.WriteLine($"Bebida não encontrada");
    break;
}

