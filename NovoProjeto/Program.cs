using System;
using System.Globalization;
using Course;

namespace Couser
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine(" Dados do produto: " + p );

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);
        }
    }
}
