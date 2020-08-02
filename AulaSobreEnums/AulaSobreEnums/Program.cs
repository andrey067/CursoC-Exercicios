using System;
using AulaSobreEnums.Entities.Enums;
using AulaSobreEnums.Entities;

namespace AulaSobreEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("---------------");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
