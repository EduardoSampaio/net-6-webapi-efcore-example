using AutoMapper;
using Microsoft.OpenApi.Extensions;
using Project.Domain.Entities;
using System.Linq.Expressions;
using WebApi.DTO;
using WebApi.Repository;

namespace WebApi.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private IUnitOfWork _uow;
        private IMapper _mapper;

        public FuncionarioService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(FuncionarioDTO dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(FuncionarioDTO dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuncionarioDTO> Find()
        {
            IEnumerable<Funcionario> funcionarios = _uow.FuncionarioRepository.Find();
            return funcionarios.Select(funcionario => _mapper.Map<FuncionarioDTO>(funcionario));

        }

        public IEnumerable<FuncionarioDTO> Find(Expression<Func<Funcionario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDTO FindById(Expression<Func<FuncionarioDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(FuncionarioDTO dto)
        {
            //_uow.FuncionarioRepository.Update();
            _uow.SaveAsync();
        }
    }
}
