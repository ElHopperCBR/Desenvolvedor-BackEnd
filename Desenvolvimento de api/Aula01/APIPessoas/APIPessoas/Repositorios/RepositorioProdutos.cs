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

        public void EditarProduto(Produtos p, Produtos produto)
        {
            p = PesquisarProdutosID(produto.Id);
            p.Nome = produto.Nome;
            p.Preco = produto.Preco;
            p.Descricao = produto.Descricao;
            p.Quantidade = produto.Quantidade;
            contexto.Update(p);
            contexto.SaveChanges();
        }

    }
}
