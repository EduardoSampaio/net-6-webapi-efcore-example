using AutoMapper;
using Project.Domain.Entities;
using System.Linq.Expressions;
using WebApi.DTO;
using WebApi.Repository;

namespace WebApi.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IUnitOfWork _uow;
        private IMapper _mapper;

        public FuncionarioService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(FuncionarioDTO dto)
        {
            var entity = _mapper.Map<Funcionario>(dto);
            _uow.FuncionarioRepository.Add(entity);
            _uow.Complete();
        }

        public void Delete(int id)
        {
            var entity = _uow.FuncionarioRepository.FindById(id);

            if (entity is null) {
                throw new Exception("Entidade Não Encontrada");
            }
            _uow.FuncionarioRepository.Delete(entity);
            _uow.Complete();
        }

        public IEnumerable<FuncionarioDTO> Find()
        {
            var funcionarios = _uow.FuncionarioRepository.Find();
            return funcionarios.Select(funcionario => _mapper.Map<FuncionarioDTO>(funcionario));
        }

        public IEnumerable<FuncionarioDTO> Find(Expression<Func<Funcionario, bool>> predicate)
        {
            var funcionarios = _uow.FuncionarioRepository.Find(predicate);
            return funcionarios.Select(funcionario => _mapper.Map<FuncionarioDTO>(funcionario));
        }

        public FuncionarioDTO FindById(int id)
        {
           var entity = _uow.FuncionarioRepository.FindById(id);
           return _mapper.Map<FuncionarioDTO>(entity);
        }

        public void Update(FuncionarioDTO dto)
        {
            var entity = _uow.FuncionarioRepository.FindById(dto.FuncionarioId);

            if (entity is null)
            {
                throw new Exception("Entidade Não Encontrada");
            }

            entity.Nome = dto.Nome;
            entity.Salario = dto.Salario;
            entity.Idade = dto.Idade;
            entity.Matricula = dto.Matricula;
            
            _uow.FuncionarioRepository.Update(entity);
            _uow.Complete();
        }
    }
}
