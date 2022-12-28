using Project.Domain.Entities;

namespace WebApi.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
        IFuncionarioRepository FuncionarioRepository { get; }
    }
}
