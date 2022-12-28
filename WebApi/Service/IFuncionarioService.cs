using Project.Domain.Entities;
using System.Linq.Expressions;
using WebApi.DTO;

namespace WebApi.Service
{
    public interface IFuncionarioService
    {
        FuncionarioDTO FindById(Expression<Func<FuncionarioDTO, bool>> predicate);
        IEnumerable<FuncionarioDTO> Find();
        IEnumerable<FuncionarioDTO> Find(Expression<Func<Funcionario, bool>> predicate);
        void Add(FuncionarioDTO dto);
        void Delete(FuncionarioDTO dto);
        void Update(FuncionarioDTO dto);
    }
}
