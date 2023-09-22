using Microsoft.Extensions.DependencyInjection;
using ProductsCRUD.Data;
using ProductsCRUD.Extensions;
using ProductsCRUD.Interfaces.Services;

namespace ProductsCRUD;

public class ChamarServico
{
    public static void ChamarCRUD()
    {
        bool continuar = true;

        var serviceCollection = new ServiceCollection();
        DependencyInjection.ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();
        var eventService = serviceProvider.GetService<IProductService>();

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar produto");
            Console.WriteLine("2. Remover produto pelo ID");
            Console.WriteLine("3. Editar nome do produto pelo ID");
            Console.WriteLine("4. Visualizar todos os produtos");
            Console.WriteLine("5. Visualizar produto por ID");
            Console.WriteLine("6. Sair");

            var opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    eventService!.AdicionarProduto();
                    break;
                case 2:
                    eventService!.RemoverProduto();
                    break;
                case 3:
                    eventService!.EditarNomeDoProduto();
                    break;
                case 4:
                    eventService!.VisualizarTodosProdutos();
                    break;
                case 5:
                    eventService!.VizualizarProdutoID();
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }
}
