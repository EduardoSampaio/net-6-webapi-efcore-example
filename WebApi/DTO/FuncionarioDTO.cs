using Project.Domain.Entities;
using Project.Domain.Enums;

namespace WebApi.DTO
{
    public class FuncionarioDTO
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }
        public Sexo Sexo { get; set; }

    }
}
