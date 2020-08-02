using System;
using System.Globalization;
namespace problema_exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto");
            Console.WriteLine("Nome do Produto");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade do produto");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto" + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine("Dados atualizado: " + p);

            Console.WriteLine("_____________");

            Console.WriteLine("Digite o valor a ser removido da quantidade");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine("Dados Atualizado: "+ p);
        }
    }
}
