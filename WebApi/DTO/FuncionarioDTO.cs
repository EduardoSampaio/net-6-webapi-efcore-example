using Project.Domain.Entities;
using Project.Domain.Enums;

namespace WebApi.DTO
{
    public class FuncionarioDTO
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }
        public int Idade { get; set; }


    }
}
