// string carro = "Opala";

// // Console.WriteLine($"Cadastre o nome do carro");
// // carro = Console.ReadLine();

// Console.WriteLine($"O carro é {carro}");

// carro = "fusca";

// Console.WriteLine($"O carro é {carro}");


// string[] carros = new string[3];
// carros[0] = "Tesla";
// carros[1] = "Maverick";
// carros[2] = "Celta 94";

// // carros[3] = "ferrari";

// Console.WriteLine($"Os carros cadastrados são ({carros[0]}, {carros[1]}, {carros[2]})");

// criar um array de strings para armazenar 3 carros

string[] carros = new string[3];

for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine($"Informe o nome do carro:");
    carros[i] = Console.ReadLine();
}
Console.WriteLine($" ");
Console.WriteLine($"Carros cadastrados com sucesso !");


// for (int i = 0; i < carros.Length; i++)
// {
//    Console.WriteLine($"Os carros cadastradados são {carros[i]}");
// }

foreach (var item in carros)
{
    Console.WriteLine(item);
    
}