using Microsoft.Extensions.Logging;
using WebApi.EF;

namespace WebApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public MyContext _context;

        private IFuncionarioRepository _funcionarioRepository;

        public UnitOfWork(MyContext context)
        {
            _context = context;
        }

        public IFuncionarioRepository FuncionarioRepository => _funcionarioRepository ??= new FuncionarioRepository(_context);

        public bool Complete()
        {
            return _context.SaveChanges() > 0;
        }

    }
}

