using System;
using System.Globalization;
namespace problema_exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 900.00, 10);

            //p.Nome = "TV 4K";
            //Console.WriteLine(p.Nome);

            //Console.WriteLine(p.Preco);
            Console.WriteLine(p.ToString());
































            //Console.WriteLine("Entre os dados do produto");
            //Console.WriteLine("Nome do Produto");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Preço do Produto");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ////Console.WriteLine("Quantidade do produto");
            ////int quantidade = int.Parse(Console.ReadLine());

            ////Produto p = new Produto(nome,preco);

            //Produto p3 = new Produto{ 
            //    Nome = "TV", 
            //    Preco = 500.00, 
            //    Quantidade = 20 };

            //Console.WriteLine("Dados do produto" + p);

            //Console.WriteLine("Digite o número de produtos a ser adicionado:");
            //int qtd = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qtd);
            //Console.WriteLine("Dados atualizado: " + p);

            //Console.WriteLine("_____________");

            //Console.WriteLine("Digite o valor a ser removido da quantidade");
            //qtd = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qtd);

            //Console.WriteLine("Dados Atualizado: " + p);
        }
    }
}
