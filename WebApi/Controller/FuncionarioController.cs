using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<FuncionarioDTO> GetAll()
        {
            return _funcionarioService.Find();
        }

        [HttpGet("{id}")]
        public FuncionarioDTO GetById(int id)
        {
            return _funcionarioService.FindById(id);
        }

        [HttpDelete("{id}")]
        public void DeleteById(int id)
        {
            _funcionarioService.Delete(id);
        }

        [HttpPut]
        public void Update(FuncionarioDTO dto)
        {
            _funcionarioService.Update(dto);
        }

        [HttpPost]
        public void Save(FuncionarioDTO dto)
        {
            _funcionarioService.Add(dto);
        }
    }
}
