using Produto_interface;

// instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty",480f);
Produto p2 = new Produto(2, "Mineirinho Ultra Adventures",2.30f);
Produto p3 = new Produto(3, "The Last of Us",150f);

// adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

// listar
carrinho.Listar();

carrinho.ValorTotal();

carrinho.Remover(p1);

Console.WriteLine($"Após remover um objeto");

carrinho.Listar();

carrinho.ValorTotal();

Console.WriteLine($"Atualizado");

Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Mineirinho Directors Cut";
produtoAtualizado.Preco = 2.50f;

carrinho.Atualizar(2, produtoAtualizado);

carrinho.Listar();

carrinho.ValorTotal();


