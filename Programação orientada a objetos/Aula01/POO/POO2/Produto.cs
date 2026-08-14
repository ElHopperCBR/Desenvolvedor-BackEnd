namespace POO2
{
    internal class Produto
    {
        //Campos
        public string nome;
        public double preco;
        public int quantidade;

        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto: {nome}\n" +
                $"Valor de compra: {preco:c}\n" +
                $"Quantidade em estoque: {quantidade}\n" +
                $"Valor total em estoque: {ValorEmEstoque():c}");
        }

        public void AdicionarProdutos(int q)
        {
            quantidade += q;
        }

        public void RemoverProdutos(int q)
        {
            quantidade -= q;
        }

        public double ValorEmEstoque()
        {
            return quantidade * preco;
        }
    }
}