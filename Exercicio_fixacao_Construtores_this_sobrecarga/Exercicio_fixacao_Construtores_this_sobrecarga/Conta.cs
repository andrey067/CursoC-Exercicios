using System;
using System.Globalization;
using System.Text;

namespace Exercicio_fixacao_Construtores_this_sobrecarga
{
    class Conta
    {
        public int Numero { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }


        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string Titular, double saldo) 
        {
            Saldo = saldo;
        }
        public void Depositar(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", "
                + "Titular: " + Titular + ","
                + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
