using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {     

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            return Ok("Método Produtos1 funcionou");
        }
    }
}
