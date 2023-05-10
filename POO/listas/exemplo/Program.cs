using exemplo;

List<Produto> produtos = new List<Produto>();

// CREATE

// Inserir objetos de produtos dentro da lista
// atráves de uma instância direta (construtor)
produtos.Add(new Produto("camiseta lacoste",1234,19.99f));

// atraves de uma instância basica de objeto 
 Produto camisetaArmani = new Produto("camiseta armani",1235,49.90f);
 produtos.Add(camisetaArmani);

// READ
Console.WriteLine($"Produtos antes da alteração");

foreach (var item in produtos)
{
    Console.WriteLine($"Nome: {item.nome}, Código: {item.codigo}, Preço {item.preco:C}");
}

// UPDATE 

// acessar um objeto da lista para poder manipulá-lo
Produto produtoEncontrado = produtos.Find(x => x.codigo == 1235);

// encontrar o índice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

// exibir o índice no console
Console.WriteLine($"O índice do produto encotrado é o: {index}");

// fazer alterações
produtoEncontrado.preco = 599f;

// remover o item antigo da lista
produtos.RemoveAt(index);

// devolver o item atualizado no lugar

produtos.Insert(index, produtoEncontrado);

Console.WriteLine($"Produtos depois da alteração");
foreach (var item in produtos)
{
    Console.WriteLine($"Nome: {item.nome}, Código: {item.codigo}, Preço {item.preco:C}");
}

// DELETE

produtos.RemoveAt(1);

foreach (var item in produtos)
{
    Console.WriteLine($"Nome: {item.nome}, Código: {item.codigo}, Preço {item.preco:C}");
}

