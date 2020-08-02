using System;

namespace Exercicio_fixacao_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {

            //modificador de parametro REF
            int a = 10;
            Calcular.Triple(ref a);
            Console.WriteLine(a);

            // Modificador out
            int b = 10;
            int triple;

            Calcular.Triple(b, out triple);
            Console.WriteLine(triple);

        }
    }
}
