using Project.Domain.Entities;
using System.Linq.Expressions;
using WebApi.DTO;

namespace WebApi.Service
{
    public interface IFuncionarioService
    {
        FuncionarioDTO FindById(int id);
        IEnumerable<FuncionarioDTO> Find();
        IEnumerable<FuncionarioDTO> Find(Expression<Func<Funcionario, bool>> predicate);
        void Add(FuncionarioDTO dto);
        void Delete(int id);
        void Update(FuncionarioDTO dto);
    }
}
