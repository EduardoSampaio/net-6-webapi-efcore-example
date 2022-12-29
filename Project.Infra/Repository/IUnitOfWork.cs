using Project.Domain.Entities;

namespace WebApi.Repository
{
    public interface IUnitOfWork
    {
        bool SaveAsync();
        void Dispose();

        IFuncionarioRepository FuncionarioRepository { get; }
    }
}
