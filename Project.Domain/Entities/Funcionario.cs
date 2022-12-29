using Project.Domain.Enums;
using WebApi.Domain.Entities;

namespace Project.Domain.Entities
{
    public class Funcionario
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
       
        public int CargoId { get; set; }

        public int EnderecoId { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<FuncionarioPermissao> FuncionarioPermissaos { get; set; }
    }
}
