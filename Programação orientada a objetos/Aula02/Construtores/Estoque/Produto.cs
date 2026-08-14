namespace Estoque
{
    internal class Produto
    {
        //Campos
        public string nome;
        public int quantidade;
        public double preco;

        //Construtor
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
        }

        public double ValorTotal() 
        {
            return preco * quantidade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}, Quantidade: {quantidade},Preço: {preco:c}, Total: {ValorTotal():c}");
        }

    }
}
