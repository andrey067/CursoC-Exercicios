using System;
using Problema_exemplo_try_catch.Entities;
namespace Problema_exemplo_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in Date (dd/MM/yyyy)");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-in Date (dd/MM/yyyy)");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut >= checkIn)
            {
                Console.WriteLine("Erro da reserva");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva realizada com sucesso" + reservation);

                Console.WriteLine("---------------------");

                Console.WriteLine("Entre com os dados para atualizar a reserva");

                Console.WriteLine("Check-in Date (dd/MM/yyyy)");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-in Date (dd/MM/yyyy)");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.updateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Erro in reservation" + error);

                }
                else
                {
                    reservation.updateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation" + reservation);





                }
            }
        }
    }
}
