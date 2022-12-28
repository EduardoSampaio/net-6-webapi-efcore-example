using AutoMapper;
using Project.Domain.Entities;
using WebApi.DTO;

namespace WebApi.Config
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<FuncionarioDTO, Funcionario>();
        }
    }
}
