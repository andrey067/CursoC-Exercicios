using System;
using System.Collections.Generic;
namespace Exercicio_fixacao_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
            Console.WriteLine("Digite a quantidade de funcionarios a ser cadastrados");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite o id do Funcionario");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionario");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o salario do funcionario");
                double salario = double.Parse(Console.ReadLine());
                funcionario = new Funcionario(id, nome, salario);
                funcionarios.Add(funcionario);
            }


            Console.WriteLine("Digite o id do funcionario que ira receber o aumento");
            int searchID = int.Parse(Console.ReadLine());

            foreach (Funcionario obj in funcionarios)
            {
                if (obj.Id.Equals(searchID))
                {
                    Console.WriteLine("Digite a porcentagem do aumento");
                    double aumento = double.Parse(Console.ReadLine());
                    obj.Aumento(aumento);
                }
                else
                {
                    Console.WriteLine("O id nao existe");
                }
                Console.WriteLine("==================");
                Console.WriteLine("Dados atualizados");
                
                foreach (Funcionario obg in funcionarios)
                {
                    Console.WriteLine(obg);

                }

            }

        }
    }
}
