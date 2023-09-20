using ProductsCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCRUD
{
    public class InterfaceDeInteracao
    {
        public static void ChamarCRUD()
        {
            bool continuar = true;

            var products = new ProductRepository();
            while (continuar)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar produto");
                Console.WriteLine("2. Remover produto pelo ID");
                Console.WriteLine("3. Editar nome do produto pelo ID");
                Console.WriteLine("4. Visualizar todos os produtos");
                Console.WriteLine("5. Visualizar todos os produtos");
                Console.WriteLine("6. Sair");

                var opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        products.AdicionarProduto();
                        break;
                    case 2:
                        products.RemoverProduto();
                        break;
                    case 3:
                        products.EditarNomeDoProduto();
                        break;
                    case 4:
                        products.VisualizarProdutos();
                        break;
                    case 5:
                        products.VizualizarProdutoID();
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
}
