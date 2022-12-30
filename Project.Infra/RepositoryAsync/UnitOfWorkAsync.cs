using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Infra.RepositoryAsync;
using WebApi.EF;

namespace WebApi.Repository
{
    public class UnitOfWorkAsync : IUnitOfWorkAsync
    {
        public MyContext _context;

        private bool _disposed;

        private IFuncionarioRepositoryAsync _funcionarioRepository;

        public UnitOfWorkAsync(MyContext context)
        {
            _context = context;
        }

        IFuncionarioRepositoryAsync IUnitOfWorkAsync.FuncionarioRepository => _funcionarioRepository ??= new FuncionarioRepositoryAsync(_context);

        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }


        public async Task CompleteAsync() => await _context.SaveChangesAsync();

        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    await _context.DisposeAsync();
                }

                _disposed = true;
            }
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}

