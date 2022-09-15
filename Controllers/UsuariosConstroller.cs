using eCommerce.api.Models;
using eCommerce.api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosConstroller : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosConstroller()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _usuarioRepository.GetUsuarioById(id);
           if(usuario == null)
            {
                return NotFound();
            } 
           return Ok(usuario);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Usuario usuario)
        {
            _usuarioRepository.insert(usuario);
            return Ok(usuario);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Usuario usuario)
        {
            _usuarioRepository.update(usuario);
            return Ok(usuario);
        }
        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            _usuarioRepository.delete(id);   
            return Ok();
        }
    }
}
