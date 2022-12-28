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
        public IEnumerable<FuncionarioDTO> GetAll() {
            return _funcionarioService.Find();
        }

        [HttpGet("{id}")]
        public int GetById(int id)
        {
            return id;
        }
    }
}
