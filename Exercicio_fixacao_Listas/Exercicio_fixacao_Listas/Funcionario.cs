using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_Listas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void Aumento(double aumento)
        {
            Salario += Salario * (aumento / 100);
        }

        public override string ToString()
        {
            return "ID: " + Id + ", "
                + "Nome: " + Nome + ", "
                + "Salario: " + Salario;
        }
    }
}
