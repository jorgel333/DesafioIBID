using ProductsCRUD.Data.Context;
using ProductsCRUD.Entities;
using ProductsCRUD.Interfaces.Repository;
using System.Globalization;

namespace ProductsCRUD.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CriarProduto(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void AtualizarNomeProduto(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public Product? BuscarProdutoId(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public void DeletarProdutoId(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> BuscarTodosProdutos()
        {
            return _context.Products.ToList();
        }
    }
}
