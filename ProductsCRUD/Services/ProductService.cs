using Microsoft.EntityFrameworkCore;
using ProductsCRUD.Entities;
using ProductsCRUD.Interfaces.Repository;
using ProductsCRUD.Interfaces.Services;
using System.Globalization;

namespace ProductsCRUD.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void AdicionarProduto()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Digite o nome do produto:");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto:");
        var preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine("Digite Digite a quantidade em estoque do produto:");
        var estoque = int.Parse(Console.ReadLine()!);

        var novoProduto = new Product(nome!, preco, estoque);
        _productRepository.CriarProduto(novoProduto);
        Console.WriteLine("Produto adicionado com sucesso.");
    }

    public void RemoverProduto()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Digite o ID do produto a ser removido:");
        var id = int.Parse(Console.ReadLine()!);

        var produtoParaRemover = _productRepository.BuscarProdutoId(id); ;
        if (produtoParaRemover is not null)
        {
            _productRepository.DeletarProdutoId(produtoParaRemover);
            Console.WriteLine("Produto removido com sucesso.");
            Console.WriteLine("-----------------------------");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
            Console.WriteLine("-----------------------------");
        }
    }

    public void EditarNomeDoProduto()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Digite o ID do produto a ser editado:");
        var id = int.Parse(Console.ReadLine()!);

        var produtoParaEditar = _productRepository.BuscarProdutoId(id);
        if (produtoParaEditar is not null)
        {
            Console.WriteLine("Digite o novo nome do produto:");
            var novoNome = Console.ReadLine()!;

            produtoParaEditar.UpdateNome(novoNome);
            _productRepository.AtualizarNomeProduto(produtoParaEditar);
            Console.WriteLine("Nome do produto atualizado com sucesso.");
            Console.WriteLine("-----------------------------");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
            Console.WriteLine("-----------------------------");
        }
    }

    public void VizualizarProdutoID()
    {
        Console.WriteLine("Digite o ID do produto:");
        var id = int.Parse(Console.ReadLine()!);

        var produto = _productRepository.BuscarProdutoId(id);

        if (produto is not null)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(produto);
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
    public void VisualizarTodosProdutos()
    {
        var products = _productRepository.BuscarTodosProdutos();
        if (!products.Any())
        {
            Console.WriteLine("Lista de produtos vazia.");
            Console.WriteLine("-----------------------------");
        }
        else
        {
            Console.WriteLine("Lista de Produtos:");
            Console.WriteLine("------------------------------------------");
            foreach (var produto in products)
            {
                Console.WriteLine(produto);
                Console.WriteLine("---------------------------------------------");
            }
        }

    }
}
