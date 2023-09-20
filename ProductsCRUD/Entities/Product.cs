using System.Globalization;

namespace ProductsCRUD.Entities
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string? Nome { get; private set; }
        public double Preco { get; private set; }
        public int Estoque { get; private set; }

        public Product(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void UpdateNome(string novoNome)
        {
            Nome = novoNome;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Nome: {Nome}\n" +
                $"Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Estoque: {Estoque}";
        }
    }
}
