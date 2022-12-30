using AutoMapper;
using Microsoft.JSInterop.Infrastructure;
using Project.Domain.Entities;
using Project.Infra.RepositoryAsync;
using System.Linq.Expressions;
using WebApi.DTO;
using WebApi.Repository;

namespace WebApi.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IUnitOfWorkAsync _uow;
        private IMapper _mapper;

        public FuncionarioService(IUnitOfWorkAsync uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(FuncionarioDTO dto)
        {
            var entity = _mapper.Map<Funcionario>(dto);
            _uow.FuncionarioRepository.AddAsync(entity);
            _uow.Complete();
        }

        public async void Delete(int id)
        {
            var entity = await _uow.FuncionarioRepository.GetByIdAsync(id);

            if (entity is null) {
                throw new Exception("Entidade Não Encontrada");
            }
            await _uow.FuncionarioRepository.DeleteAsync(entity);
            await _uow.CompleteAsync();
        }

        public async Task<IEnumerable<FuncionarioDTO>> Find()
        {
            var funcionarios = await _uow.FuncionarioRepository.GetAllAsync();
            return funcionarios.Select(funcionario => _mapper.Map<FuncionarioDTO>(funcionario));
        }

        public async Task<IEnumerable<FuncionarioDTO>> Find(Expression<Func<Funcionario, bool>> predicate)
        {
            var funcionarios = await _uow.FuncionarioRepository.GetAllAsync(predicate);
            return funcionarios.Select(funcionario => _mapper.Map<FuncionarioDTO>(funcionario));
        }

        public async Task<FuncionarioDTO> FindById(int id)
        {
           var entity = await _uow.FuncionarioRepository.GetByIdAsync(id);
           return _mapper.Map<FuncionarioDTO>(entity);
        }

        public void Update(FuncionarioDTO dto)
        {
            var entity = _uow.FuncionarioRepository.GetById(dto.FuncionarioId);

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
