using LibraryDev.Application.Commands.Livros;
using LibraryDev.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarLivro([FromBody] CriarLivroCommand command)
        {
            var result = await _livroService.CriarLivro(command);
            return Ok(result);
        }
    }
}
