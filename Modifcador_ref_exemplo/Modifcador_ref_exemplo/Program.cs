using System;

namespace Modifcador_ref_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificador ref
            int a = 10;
            calculator.Triple( ref a);
            Console.WriteLine(a);

            //Modificador out
            a = 10;
            int triple;
            calculator.Triple_2(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
