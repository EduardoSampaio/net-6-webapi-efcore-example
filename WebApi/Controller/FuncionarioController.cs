using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.DTO;
using WebApi.Repository;
using WebApi.Service;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var resultado = await _funcionarioService.Find();
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var resultado = await _funcionarioService.FindById(id);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _funcionarioService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(FuncionarioDTO dto)
        {
            _funcionarioService.Update(dto);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Save(FuncionarioDTO dto)
        {
            await _funcionarioService.AddAsync(dto);
            var location = Url.Action(nameof(GetById), new { id = dto.FuncionarioId }) ?? $"/{dto.FuncionarioId}";
            return Created(location, dto);
        }
    }
}
