using Aluguel.Classes.Entidades;
using Aluguel.Classes.Servicos;
using Aluguel.Interfaces;

Console.WriteLine("Locação de veiculo");
Console.Write("Modelo de carro: ");
string modelo = Console.ReadLine();
Console.Write("Retirada dd/MM/yyyy hh:mm  ");
DateTime retirada = DateTime.Parse(Console.ReadLine());
Console.Write("Devolução dd/MM/yyyy hh:mm  ");
DateTime devolucao = DateTime.Parse(Console.ReadLine());

AluguelCarro aluguel = new AluguelCarro(retirada,devolucao,modelo);

Console.Write("Entre com o preço por hora: ");
double preco1 = double.Parse(Console.ReadLine());
Console.Write("Entre com o preço por dia: ");
double preco2 = double.Parse(Console.ReadLine());

ITaxaServ taxa = new TaxaServBrasil();

ServAluguel aluguelServ = new ServAluguel(preco1,preco2,taxa);

aluguelServ.CalcularFatura(aluguel);

Console.WriteLine(aluguelServ.ToString());

