using System;

namespace Exercicio_fixacao_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("Digite quantos quartos serao alugados");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Quarto #{i}:");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email para contanto:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite qual quarto quer alugar");
                //pulo do gato
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine("-------------");
            Console.WriteLine( "Quartos ocupados");
            for(int i=1; i<10;i++)
            {
                if (vect[i] != null) {
                    Console.WriteLine(i +": "+ vect[i]);
                
                }
            }

        }
    }
}
