using Back_end_1.POO.listas.ExercicioCarro;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Qual a marca do carro ?");
    string marca = Console.ReadLine();

    Console.WriteLine($"Qual o modelo do carro ?");
    string modelo = Console.ReadLine();

    Console.WriteLine($"Qual a cor do carro ?");
    string cor = Console.ReadLine();

    Carro carro = new Carro(marca,modelo,cor);
    carros.Add(carro);   
}

foreach (var item in carros)
{
    Console.WriteLine($"A marca do carro é {item.Marca} do modelo {item.Modelo} de  cor {item.Cor}");
}