using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("ObterDataHoraAtual")] 
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                // metodo que retorna data e horario atual
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };

            // metodo: requisão http/obj
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")] 

        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new {mensagem});
        }
    }

    
}