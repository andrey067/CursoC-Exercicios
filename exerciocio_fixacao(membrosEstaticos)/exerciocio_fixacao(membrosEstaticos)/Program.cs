using System;

namespace exerciocio_fixacao_membrosEstaticos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotacao do dolar?");
            double dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos dolares voce vai comprar?");
            double moeda = double.Parse(Console.ReadLine());

            double total = Conversor.CalcularTaxa(dolar, moeda);

            Console.WriteLine("Valor da moeda: " + total);
        }
    }
}
