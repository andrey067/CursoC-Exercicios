using System;
using System.Globalization;

namespace Problema_exemplo_2_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite nome do" + i + "produto");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o valor do " + i + "produtos");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;

            }
            double avg = sum / n;
            Console.WriteLine("A media de preços dos produtos é:"+ avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
