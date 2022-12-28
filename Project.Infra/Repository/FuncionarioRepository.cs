using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using WebApi.EF;

namespace WebApi.Repository
{
    public class FuncionarioRepository : Repository<Funcionario, int>, IFuncionarioRepository
    {
        MyContext _context;
        public FuncionarioRepository(MyContext context) : base(context)
        {
            _context = context;
        }
    }
}
