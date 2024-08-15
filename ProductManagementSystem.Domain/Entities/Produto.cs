namespace ProductManagementSystem.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoBase { get; set; }
        public ICollection<Variacao> Variacoes { get; set; }
    }
}
