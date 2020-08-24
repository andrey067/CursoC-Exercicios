using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_exemplo_try_catch.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime CheckIN { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIN, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIN = checkIN;
            CheckOut = checkOut;
        }

        public int Duratinon()
        {
            TimeSpan duration = CheckOut - CheckIN;
            return (int)duration.TotalDays;
        }

        public string updateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn > now || checkOut < now)
            {
                return "Erro na reserva: As datas da reserva deve ser datas futuras";
            }
            if (checkOut <= checkIn)
            {
                return "Erro na reserva: As datas da reserva deve ser datas futuras";
            }

            CheckIN = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return "Room" + RoomNumber
                + "check-In: " + CheckIN.ToString("dd/MM/yyyy")
                + "check-Out: " + CheckOut.ToString("dd/MM/yyyy")
                + "Duration" + Duratinon() + "nights";
        }
    }
}
