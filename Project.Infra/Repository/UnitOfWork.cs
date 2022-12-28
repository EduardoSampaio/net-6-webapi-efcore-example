using Project.Domain.Entities;
using WebApi.EF;

namespace WebApi.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public MyContext _context;
        private IFuncionarioRepository _funcionarioRepository;

        public UnitOfWork(IFuncionarioRepository funcionarioRepository, MyContext context)
        {
            _funcionarioRepository = funcionarioRepository;
            _context = context;
        }

        public IFuncionarioRepository FuncionarioRepository => _funcionarioRepository;

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

