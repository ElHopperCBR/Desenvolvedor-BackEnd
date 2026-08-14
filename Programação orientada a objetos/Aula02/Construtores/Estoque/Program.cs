using Estoque;

//Declaração de variavei
string nome;
int qtd;
double preco;

//Entrada de dados
Console.Write("Digite o nome do produto: ");
nome = Console.ReadLine();
Console.Write("Digite a quantidade de produto: ");
qtd = int.Parse(Console.ReadLine());
Console.Write("Digite o preço do produto: R$ ");
preco = double.Parse(Console.ReadLine());


Produto objeto = new Produto(nome,qtd,preco);
Produto objeto2 = new Produto(nome,preco);

Math.Sqrt(4);




Console.WriteLine();
Console.ReadKey();