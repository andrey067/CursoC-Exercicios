using System;

namespace TimesSpan_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            //passando o formato em ticks
            TimeSpan t2 = new TimeSpan(9000000000L);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t3);
            //Dias
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);
            //com milisegundos
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);
            //metods Form
            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t6);

            //Propriedade e operacoes
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayofWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millseconds: " + d.Millisecond);
            Console.WriteLine("2) Minute: " + d.Minute);
            Console.WriteLine("2) Month: " + d.Month);
            Console.WriteLine("2) Second: " + d.Second);
            Console.WriteLine("2) Ticks: " + d.Ticks);
            Console.WriteLine("2) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("2) Year: " + d.Year);

            Console.WriteLine(d.ToLongDateString());

            //mascara de formatacao
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);
            //acrecentando valores a data
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d1);
            DateTime d2 = d1.AddHours(2);

            Console.WriteLine(d2);

            //Propriedades Times_span

            TimeSpan t7 = TimeSpan.MaxValue;
            TimeSpan t8 = TimeSpan.MinValue;
            TimeSpan t9 = TimeSpan.Zero;
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine("----------------");
            TimeSpan r = new TimeSpan(2, 3, 5, 7, 11);


            Console.WriteLine("Days" + r.Days);
            Console.WriteLine("hours" + r.Hours);
            Console.WriteLine("Minutes" + r.Minutes);
            Console.WriteLine("Miliseconds" + r.Milliseconds);
            Console.WriteLine("Seconds" + r.Seconds);
            Console.WriteLine("Days" + r.Days);
            Console.WriteLine("Ticks" + t1.Ticks);

            Console.WriteLine("TotalDays" + r.TotalDays);
            Console.WriteLine("TotalHours" + r.TotalHours);
            Console.WriteLine("TotalMinutes" + r.TotalMinutes);
            Console.WriteLine("TotalSeconds" + r.TotalSeconds);
            Console.WriteLine("TotalMiliseconds" + r.TotalSeconds);
            //TimeSpan operacoes
            TimeSpan n = new TimeSpan(1, 30, 10);
            TimeSpan m = new TimeSpan(0, 10, 5);
            Console.WriteLine("---------");
            TimeSpan soma = n.Add(m);
            TimeSpan subtract = n.Subtract(m);
            TimeSpan mult = m.Multiply(2.0);
            TimeSpan div = m.Divide(2.0);
            Console.WriteLine(soma);
            Console.WriteLine(subtract);
            Console.WriteLine(mult);
            Console.WriteLine(div);


            //Boas praticas, formato UTC para BD,Jason,XML

            DateTime d5 = new DateTime(2000, 8, 25, 13, 5, 58, DateTimeKind.Local);
            DateTime d6 = new DateTime(2000, 8, 25, 13, 5, 58, DateTimeKind.Utc);
            DateTime d7 = new DateTime(2000, 8, 25, 13, 5, 58);
            Console.WriteLine("d5 "+d5);
            Console.WriteLine("d6 kind"+d6.Kind);
            Console.WriteLine("d7 tolocalTime"+d7.ToLocalTime());
            Console.WriteLine("d5.toUTC "+ d5.ToUniversalTime());

        }
    }
}
