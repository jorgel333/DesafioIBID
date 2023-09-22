using ProductsCRUD.Entities;

namespace ProductsCRUD.Interfaces.Repository;

public interface IProductRepository
{
    void CriarProduto(Product product);
    void AtualizarNomeProduto(Product product);
    void DeletarProdutoId(Product product);
    IEnumerable<Product> BuscarTodosProdutos();
    Product? BuscarProdutoId(int id);
}
