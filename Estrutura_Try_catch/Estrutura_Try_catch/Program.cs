using System;

namespace Estrutura_Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divisao por zero nao é permitido!!" + e.Message);

            }
            catch (FormatException e) {
                Console.WriteLine("Formart Erro -  " +e.Message);
            }
        }
    }
}
