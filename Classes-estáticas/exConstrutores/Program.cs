using exConstrutores;

// construtor vazio
Produto p1 = new Produto();

// construtor com um só paramêtro
Produto p2 = new Produto(100);

// construtor com 3 paramêtro
Produto p3 = new Produto("celular",102,1000);

Console.WriteLine($"{p3.nome},{p3.codigo},{p3.estoque}");
