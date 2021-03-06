﻿using System.Globalization;
namespace problema_exemplo_2
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set;}
        public int Quantidade { get; private set; }

        public Produto()
        {

        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


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
            return _nome +
                ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", "
                + Quantidade
                + "unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }




    }
}
