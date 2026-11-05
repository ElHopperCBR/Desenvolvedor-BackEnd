using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UltimaAula.Models.Entidades;
using UltimaAula.Servicos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UltimaAula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        string chaveSecreta = "super-chave-super-secreta-supersegura";
        JwtTokenService jwt;

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromBody] Usuario usuario)
        {
            try
            {
                
                jwt = new JwtTokenService(chaveSecreta);
                return Ok(new { usuario, token = jwt.GerarToken(usuario) });

            }
            catch (Exception e)
            {
                return BadRequest("Erro = " + e.Message);
            }
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromHeader] string token)
        {
            jwt = new JwtTokenService(chaveSecreta);

            if (jwt.ValidarToken(token) == "Admin")
            {
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 401;
            }
        }
    }
}
