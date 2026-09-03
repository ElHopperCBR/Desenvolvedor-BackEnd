using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;
using Microsoft.EntityFrameworkCore.Query.Internal;

ProdutoContexto contexto = new ProdutoContexto();

contexto.Database.EnsureCreated();

bool continuar = true;

while (continuar)
{
    Console.WriteLine("-- Menu do almoxarifado --" +
        "\n 1 - Consultar item no estoque" +
        "\n 2 - Cadastrar novo produto" +
        "\n 3 - Sair");
    Console.Write("\nEscolha uma opção: ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            //Consulta ao item no estoque
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigoProduto != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"Código do produto não encontrado, código: {codigo}\n");
            }
            break;
        case 2:
            //Cadastro do item no estoque
            CadastroDeItem(contexto);
            break;
        case 3:
            //Deletar item no estoque
            DeletarItem(contexto);
            break;
        case 4:
            //Sair
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;
        default:
            break;
    }
}

void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine("=== Cadastro de item ===");
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();

    if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Não permitido cadastro de produto sem nome");
        return;
    }

    Console.Write("Digite a quantidade de produto: ");
    int qtd = int.Parse(Console.ReadLine());
    if (qtd < 0)
    {
        Console.WriteLine("Não permitido valores negativo de itens");
    }
    Console.Write("Digite o custo do produto: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    if (valor < 0)
    {
        Console.WriteLine("Não permitido cadastrar valores negaticos de custo de produto");
    }

    Produto produto1 = new Produto(nome, qtd, valor);
    contexto.Produtos.Add(produto1);
    contexto.SaveChanges();
    produto1.ExibirDados();
}

void DeletarItem(ProdutoContexto contexto)
{
    Console.Write("Digite o código do produto: ");
    int codigo = int.Parse(Console.ReadLine());
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);

    if (codigoProduto != null)
    {
        Console.Write("Deseja realmente realizar esta operação (s/n)? ");
        char escolha = char.Parse(Console.ReadLine().ToLower());
        if (escolha.Equals('s'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine("Operação realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Operação cancelada");
            return;
        }
    }
}