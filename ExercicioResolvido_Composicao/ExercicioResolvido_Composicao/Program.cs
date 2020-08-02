using ExercicioResolvido_Composicao.Entities;
using ExercicioResolvido_Composicao.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioResolvido_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Departamento");
            string depName = Console.ReadLine();
            Console.WriteLine("Digite os dados do trabalho:");

            Console.WriteLine("Digite o nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Level(Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Digite o salario do funcionario");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(depName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos vai ter?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com o #{i} dados do contrato:");
                Console.WriteLine("Date DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora");
                double valeuPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duracao por horas");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valeuPerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Entre com o mes e ano(MM/YYYY) para calcular:");
            string monthAndYear = Console.ReadLine();
            int month =int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name:"+worker.Nome);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine("A receber: "+ monthAndYear +": "+ worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
