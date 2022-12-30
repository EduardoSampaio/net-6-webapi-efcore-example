using Project.Domain.Entities;
using System.Linq.Expressions;
using WebApi.DTO;

namespace WebApi.Service
{
    public interface IFuncionarioService
    {
        Task<FuncionarioDTO> FindById(int id);
        Task<IEnumerable<FuncionarioDTO>> Find();
        Task<IEnumerable<FuncionarioDTO>> Find(Expression<Func<Funcionario, bool>> predicate);
        Task AddAsync(FuncionarioDTO dto);
        Task Delete(int id);
        void Update(FuncionarioDTO dto);
    }
}
