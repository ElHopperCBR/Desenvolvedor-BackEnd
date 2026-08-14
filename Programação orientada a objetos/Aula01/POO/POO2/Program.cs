using POO2;
//Declaração de variavel
//Produto p = new();
Produto p = new Produto();
int quantidade;


//Entrada de dados
Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
p.nome = Console.ReadLine();
Console.Write("Preço: ");
p.preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
p.quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: ");
p.ExibirDados();

Console.Write("Digite o n° de produtos a ser adicionado ao estoque: ");
quantidade = int.Parse(Console.ReadLine());
p.AdicionarProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();

Console.Write("Digite o n° de produtos a ser removido do estoque: ");
quantidade = int.Parse(Console.ReadLine());
p.RemoverProdutos(quantidade);
Console.WriteLine("Dados atualizados");
p.ExibirDados();