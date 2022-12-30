using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repository;

namespace Project.Infra.RepositoryAsync
{
    public interface IUnitOfWorkAsync: IAsyncDisposable
    {
        Task CompleteAsync();

        void Complete();

        IFuncionarioRepositoryAsync FuncionarioRepository { get; }
    }
}
