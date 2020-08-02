using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace problema_exemplo_2
{
    class Produto
    {
        public String Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;

        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;

        }
        public override string ToString()
        {
            return Nome +
                ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



        
    }
}
