using Project.Domain.Enums;

namespace Project.Domain.Entities
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }
        public int Idade { get; set; }
    }
}
