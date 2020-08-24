using exericicio_resolvido_Interfaces.Entities;
using exericicio_resolvido_Interfaces.Services;
using System;
using System.Globalization;

namespace exericicio_resolvido_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Car model");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Pickup (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o preco por Hora");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o preco por Dia");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
