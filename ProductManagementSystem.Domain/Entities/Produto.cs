namespace ProductManagementSystem.Domain.Entities
{
    public class Produto
    {
        public Produto(string nome, decimal precoBase)
        {
            ValidaCategoria(nome, precoBase);
            Nome = nome;
            PrecoBase = precoBase;
        }
        public int Id { get; set; }
        public string Nome { get; private set; }
        public decimal PrecoBase { get; private set; }
        public ICollection<Variacao>? Variacoes { get; set; }

        public void AtualizarProduto(string nome, decimal precoBase)
        {
            ValidaCategoria(nome, precoBase);
            Nome = nome;
            PrecoBase = precoBase;
        }

        private void ValidaCategoria(string nome, decimal preco)
        {
            if (string.IsNullOrEmpty(nome))
                throw new InvalidOperationException("O nome é inválido");
            if (decimal.IsNegative(preco))
                throw new InvalidOperationException("O precoBase é inválido");
        }
    }
}
