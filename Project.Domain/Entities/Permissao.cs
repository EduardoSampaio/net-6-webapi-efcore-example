namespace WebApi.Domain.Entities
{
    public class Permissao
    {
        public int PermissaoId { get; set; }
        public string Nome { get; set; }

        public ICollection<FuncionarioPermissao> FuncionarioPermissaos { get; set; }
    }
}
