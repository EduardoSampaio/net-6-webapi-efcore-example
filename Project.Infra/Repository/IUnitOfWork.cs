using Project.Domain.Entities;

namespace WebApi.Repository
{
    public interface IUnitOfWork
    {
        bool Complete();

        IFuncionarioRepository FuncionarioRepository { get; }
    }
}
