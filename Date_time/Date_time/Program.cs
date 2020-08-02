using System;
using System.Globalization;

namespace Date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hora Atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //hora em ticks
            Console.WriteLine(d1.Ticks);
            DateTime d2 = new DateTime(2020, 11, 25);
            Console.WriteLine(d2);
            //especificando horario
            //DateTime d3 = new DateTime(2020, 22, 07, 9, 45, 03);
            //Console.WriteLine(d3);
            Console.WriteLine("________________");
            //convertendo string em data
            DateTime d4 = DateTime.Parse("2020-08-15");
            Console.WriteLine(d4);
            //ParseExact
            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(d5);


 
        }
    }
}
