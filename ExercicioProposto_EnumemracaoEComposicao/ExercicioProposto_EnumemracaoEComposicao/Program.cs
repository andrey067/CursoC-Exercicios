using System;
using System.Globalization;
using ExercicioProposto_EnumemracaoEComposicao.Entities;
using ExercicioProposto_EnumemracaoEComposicao.Entities.Enums;

namespace ExercicioProposto_EnumemracaoEComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data do cliente: ");
            Console.Write("Name: ");
            string clienteName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Aniversario (DD/MM/YYYY)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clienteName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos itens tem no pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}
