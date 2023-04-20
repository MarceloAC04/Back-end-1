using personagem;

Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome do personagem");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do personagem");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite a armadura do personagem");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Digite a ia do personagem");
p1.ia = Console.ReadLine();

Console.WriteLine(@$"
     {p1.nome}
     {p1.idade}
     {p1.armadura}
     {p1.ia}
");

p1.Atacar();

Console.WriteLine(p1.Defendeu());
p1.RestaurarArmadura();


