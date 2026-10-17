using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;
using APIPessoas.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {

        RepositorioProdutos rep = new RepositorioProdutos();

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            var lista = rep.ListaProdutos();
            return Ok(lista);
        }

        [HttpGet("PesquisarProdutosID/{valorID}")]
        public IActionResult PesquisarProdutosID(int valorID)
        {
            try
            {                
                var valor = rep.PesquisarProdutosID(valorID); ;
                if (valor != null)
                {
                    return Ok(valor);
                }
                else
                {
                    return NotFound("Valor não encontrado");
                }
            }
            catch (Exception)
            {

                return BadRequest("Valor informado incorreto, por favor pesquise somente números inteiros");
            }
        }

        [HttpPost("CriarProduto")]
        public IActionResult CriarProduto([FromBody]Produtos produto)
        {
            try
            {
                rep.CriarProduto(produto);
                return Ok("Produto criado na base de dados");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("EditarProduto/{id}")]
        public IActionResult EditarProduto(int id, [FromBody]Produtos produto)
        {
            try
            {
                Produtos p = rep.PesquisarProdutosID(id);
                if (p == null)
                {
                    return NotFound("Produto para editar não encontrado na base de dados");
                }
                else
                {
                    rep.EditarProduto(p, produto);
                    return Ok("Produto editado com sucesso");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
