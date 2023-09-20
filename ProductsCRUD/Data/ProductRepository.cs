using ProductsCRUD.Data.Context;
using ProductsCRUD.Entities;
using System.Globalization;

namespace ProductsCRUD.Data
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext context;
        public ProductRepository()
        {
            context = new ApplicationDbContext();
        }
        public void AdicionarProduto()
        {
            Console.WriteLine("Digite o nome do produto:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            var preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Digite Digite a quantidade em estoque do produto:");
            var estoque = int.Parse(Console.ReadLine()!);

            var novoProduto = new Product(nome!, preco, estoque);
            context.Products.Add(novoProduto);
            context.SaveChanges();
            Console.WriteLine("Produto adicionado com sucesso.");
        }

        public void RemoverProduto()
        {
            Console.WriteLine("Digite o ID do produto a ser removido:");
            var id = int.Parse(Console.ReadLine()!);

            var produtoParaRemover = context.Products.FirstOrDefault(p => p.Id == id)!;
            if (produtoParaRemover != null)
            {
                context.Products.Remove(produtoParaRemover);
                context.SaveChanges();
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void EditarNomeDoProduto()
        {
            Console.WriteLine("Digite o ID do produto a ser editado:");
            var id = int.Parse(Console.ReadLine()!);

            var produtoParaEditar = context.Products.FirstOrDefault(p => p.Id == id)!;
            if (produtoParaEditar != null)
            {
                Console.WriteLine("Digite o novo nome do produto:");
                var novoNome = Console.ReadLine()!;

                produtoParaEditar.UpdateNome(novoNome);
                context.SaveChanges();
                Console.WriteLine("Nome do produto atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void VizualizarProdutoID()
        {
            Console.WriteLine("Digite o ID do produto a ser editado:");
            var id = int.Parse(Console.ReadLine()!);

            var produto = context.Products.FirstOrDefault(p => p.Id == id)!;

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
        public void VisualizarProdutos()
        {
            var products = context.Products.ToList();
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
}
