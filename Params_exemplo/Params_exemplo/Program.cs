using System;

namespace Params_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculador.Sum(new int[] { 2, 3 });//nao usando 
            int s2 = Calculador.Sum( 2, 3 );//usando params
            Console.WriteLine(s1);
            Console.WriteLine(s2);
    }
}
}
