using System;
using System.Collections.Generic;
using System.Text;

namespace exerciocio_fixacao_membrosEstaticos_
{
    class Conversor
    {
        public static double iof = 6.0;

        public static double CalcularTaxa(double dolar, double moeda)
        {
            double resultado = dolar * moeda;
            resultado = resultado + iof / 100.00;
            return resultado;
        }
    }
}
