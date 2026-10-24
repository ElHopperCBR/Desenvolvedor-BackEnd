using CasasBahia.Classes.Models.Contextos;
using CasasBahia.Classes.Models.Entidades;
using CasasBahia.Classes.Repositorios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CasasBahia.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        RepositorioLogins rep = new RepositorioLogins();

        /// <summary>
        /// Obtém a lista de usuários de login.
        /// </summary>
        /// <returns>Uma coleção de objetos <see cref="Logins"/> contendo os usuários cadastrados.</returns>
        /// <remarks> Não precisa passar argumentos para API </remarks>

        // GET: api/<LoginsController>
        [HttpGet]
        public IEnumerable<Logins> Get()
        {
            return rep.ListarUsuarios();
        }

        /// <summary>
        /// Obtém o usuário pelo identificador informado.
        /// </summary>
        /// <param name="id">Identificador do usuário.</param>
        /// <returns>Um <see cref="IActionResult"/> contendo a resposta 200 (OK) com os dados do usuário encontrado.</returns>
        // GET api/<LoginsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.PesquisarUsuarioID(id));
        }


        /// <summary>
        /// Cria uma nova conta de usuário com os dados enviados no corpo da requisição.
        /// </summary>
        /// <param name="user">Dados do usuário a ser criado.</param>
        /// <returns>Um <see cref="CreatedResult"/> quando a conta é criada com sucesso; caso ocorra erro na criação, retorna um
        /// <see cref="ConflictObjectResult"/> com a mensagem de erro.</returns>

        // POST api/<LoginsController>
        [HttpPost]
        public IActionResult Post([FromBody] Logins user)
        {
            try
            {
                rep.CriarUsuario(user);
                return Created("Conta criada com sucesso", user);
            }
            catch (Exception ex)
            {

                return Conflict(ex.Message);
            }
        }
        /// <summary>
        /// Atualiza os dados de uma conta de usuário.
        /// </summary>
        /// <param name="user">Instância de Logins com os dados da conta a serem atualizados.</param>
        /// <returns>Um IActionResult com Ok quando a conta é editada, NotFound quando a conta não é localizada ou BadRequest
        /// quando ocorre erro na solicitação.</returns>

        // PUT api/<LoginsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Logins user)
        {
            try
            {
                if (rep.EditarUsuarios(user))
                {
                    return Ok("Conta editada com sucesso!");
                }
                else
                {
                    return NotFound("Conta não encontrada");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Exclui um usuário pelo identificador informado.
        /// </summary>
        /// <param name="id">Identificador do usuário a ser excluído.</param>
        /// <returns>Um <see cref="IActionResult"/> que representa o resultado da operação: <c>200 OK</c> quando a exclusão é
        /// realizada, <c>404 Not Found</c> quando o usuário não é encontrado e <c>400 Bad Request</c> quando ocorre
        /// erro na solicitação.</returns>

        // DELETE api/<LoginsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (rep.DeletarUsuario(id))
                {
                    return Ok("Usuário deletada com sucesso!");
                }
                else
                {
                    return NotFound("Usuário não encontrado");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpOptions]
        public IActionResult Opcoes()
        {
            Response.Headers.Append("Permitidos", "GET, POST, PUT, DELETE, OPTIONS");
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult EditarUsuarioParcial(int id, [FromBody] Logins user)
        {

        }
    }
}
