using System;
using System.Collections.Generic;
using System.Text;

namespace Modifcador_ref_exemplo
{
    class calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple_2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
