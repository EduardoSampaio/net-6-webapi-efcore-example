using Microsoft.EntityFrameworkCore.Storage;
using Project.Domain.Entities;
using WebApi.EF;

namespace WebApi.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public MyContext _context;
        private IFuncionarioRepository _funcionarioRepository;
        public UnitOfWork(MyContext context)
        {
            _context = context;
        }

        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                return _funcionarioRepository ??=  new FuncionarioRepository(_context);
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public bool SaveAsync()
        {
            return _context.SaveChanges() > 0;
        }
    }
}

