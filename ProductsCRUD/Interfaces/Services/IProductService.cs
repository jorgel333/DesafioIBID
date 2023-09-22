namespace ProductsCRUD.Interfaces.Services;

public interface IProductService
{
    void AdicionarProduto();
    void RemoverProduto();
    void EditarNomeDoProduto();
    void VizualizarProdutoID();
    void VisualizarTodosProdutos();
}
