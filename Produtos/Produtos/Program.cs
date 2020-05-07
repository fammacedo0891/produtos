using System;
using System.Globalization;
using System.Collections.Generic;
using Produtos.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Informe a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Produto #{i}");
                Console.WriteLine();

                Console.Write("Comum, Usado, Importado (c/u/i): ");
                char tipo = char.Parse(Console.ReadLine());
               
                Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                
                Console.Write("Informe o preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (tipo == 'i' || tipo == 'I')
                {
                    Console.Write("Informe a taxa de importação: ");
                    double taxaImport = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportadProduct(taxaImport, nome, preco, tipo));
                    Console.WriteLine();
                }
                else if (tipo == 'u' || tipo == 'U')
                {
                    Console.Write("Informe a data de fabricação: ");
                    DateTime dataFabric = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(dataFabric, nome, preco, tipo));
                    Console.WriteLine();
                }
                else
                {
                    list.Add(new Product(nome, preco, tipo));
                    Console.WriteLine();
                }


            }


            Console.WriteLine();
            Console.WriteLine("Preço dos produtos");
            Console.WriteLine();

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.Compra());

            }


        }
    }
}
