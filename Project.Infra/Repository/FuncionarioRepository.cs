using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Domain.Entities;
using WebApi.EF;

namespace WebApi.Repository
{
    public class FuncionarioRepository : Repository<Funcionario, int>, IFuncionarioRepository
    {
        public FuncionarioRepository(MyContext context) : base(context)
        {

        }
    }
}
