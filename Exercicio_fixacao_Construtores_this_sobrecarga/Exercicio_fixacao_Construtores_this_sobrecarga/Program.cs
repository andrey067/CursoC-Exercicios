using System;
using System.Globalization;

namespace Exercicio_fixacao_Construtores_this_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.WriteLine("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do titular:");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                Console.WriteLine("Digite o valor a ser depositado");
                double saldo = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, saldo);

            }
            else (opcao == 'n' || opcao == 'N')
            {
                conta = new Conta(numero, titular);

            }
            
            Console.WriteLine("-----------------------");

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);




        }
    }
}
