namespace Project.Domain.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}