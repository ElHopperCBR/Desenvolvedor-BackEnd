using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;

namespace APIPessoas.Repositorios
{
    public class RepositorioProdutos
    {
        //Campo
        private ProdutosContexto contexto = new ProdutosContexto();

        //Propriedade    

        protected ProdutosContexto Contexto
        {
            get { return contexto; }
            set { contexto = value; }
        }

        //Método
        /// <summary>
        /// Método para listar produtos do banco de dados sqlite
        /// </summary>
        /// <returns></returns>
        public List<Produtos> ListaProdutos()
        {
            return contexto.Produtos.ToList();
        }

        /// <summary>
        /// Pesquisa o Id no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Se encontrar o Id retorno o objeto, se não retorna um valor nulo</returns>
        public Produtos PesquisarProdutosID(int id)
        {
            var pesquisar = contexto.Produtos.FirstOrDefault(p => p.Id == id);
            return pesquisar;
        }

        /// <summary>
        /// Cria um produto na base de dados
        /// </summary>
        /// <param name="produto">Passar para a API um JSON</param>
        /// <example>
        /// {
        ///     "nome": "TV",
        ///     "preco": 2000,
        ///     "descricao": "Toca Fita",
        ///     "quantidade": -10
        /// }
        /// </example>
        public void CriarProduto(Produtos produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        /// <summary>
        /// Edita um produto existente na base de dados
        /// </summary>
        /// <param name="produto">Produto com o Id existente e os novos valores</param>
        /// <returns>true se editou; false se o produto não foi encontrado</returns>
        public bool EditarProduto(Produtos produto)
        {
            var existente = PesquisarProdutosID(produto.Id);
            if (existente == null)
                return false;

            existente.Nome = produto.Nome;
            existente.Preco = produto.Preco;
            existente.Descricao = produto.Descricao;
            existente.Quantidade = produto.Quantidade;

            contexto.SaveChanges();
            return true;
        }

    }
}
