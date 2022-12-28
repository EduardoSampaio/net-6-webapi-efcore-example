using Project.Domain.Entities;

namespace WebApi.Domain.Entities
{
    public class FuncionarioPermissao
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int PermissaoId { get; set; }
        public Permissao Permissao { get; set; }
    }
}
