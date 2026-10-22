using Banco.Classes.Models.Entidades;
using Banco.Classes.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Banco.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("aplication/json")]
    public class ContasController : ControllerBase
    {
        RepositorioContas rep = new RepositorioContas();
        /// <summary>
        /// Lista todas as contas cadastradas no banco de dados
        /// </summary>
        /// <remarks>Não precisa de parâmetros. Retorna uma lista vazia se não houver registros</remarks>
        /// <returns> Lista de contas</returns>
        /// <response code = "200"> Lista retornada com sucesso</response>
        // GET: api/<ContasController>
        [HttpGet]
        
        public IEnumerable<ContaBancaria> Get()
        {
            return rep.ListarContas();
        }

        // GET api/<ContasController>/5
        [HttpGet("{id}")]
        public IActionResult PesquisarContaPorNumero(int id)
        {
            try
            {
                var pesquisa = rep.PesquisarContasID(id);
                if (pesquisa != null)
                {
                    return Ok(pesquisa);
                }
                else
                {
                    return NotFound("Conta não encontrada na base de dados");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);                
            }
        }

        // POST api/<ContasController>
        [HttpPost]
        public IActionResult Post([FromBody] ContaBancaria conta)
        {
            try
            {
                rep.CriarConta(conta);
                return Created("Conta criada com sucesso", conta);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException e)
            {
                return Conflict(e.Message);
            }
        }

        // PUT api/<ContasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ContaBancaria conta)
        {
            try
            {
                conta.NumeroConta = id;
                if (rep.EditarConta(conta))
                {
                    return Ok("Conta editada com sucesso");
                }
                else
                {
                    return NotFound("Conta não encontrada");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/<ContasController>/5
        [HttpDelete("{numero}")]
        public IActionResult DeletarConta(int numero)
        {
            try
            {
                var existe = rep.PesquisarContasID(numero);
                if(existe != null)
                {
                    rep.DeletarConta(numero);
                    return Ok("Conta deletada com sucesso!");
                }
                else
                {
                    return NotFound("Conta bancaria não encontrada");
                }
            }
            catch (Exception e)
            {
                return BadRequest();
               
            }
        }
    }
}
