using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_ref_out
{
    class Calcular
    {
        public static void Triple(ref int x) {
            x = x * 3;
        }

        //Modificador out
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        
        }
    }
}
