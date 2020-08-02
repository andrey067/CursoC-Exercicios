using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_Herrique
{
    class Catalogo
    {
        public string TituloObra;
        public string Edicao;
        public string NomeAutor;
        public string Editora;
        public int Isbn;
        public int QuantidadeExemplares;
        public int Caixa;
        public int Ano;

        public Catalogo CargaDados()
        {
            Catalogo Titulo = new Catalogo("Tetes", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            return Titulo;
        }
        public Catalogo()
        {

        }
        
        public Catalogo(string tituloObra, string edicao, string nomeAutor, string editora, int isbn, int quantidadeExemplares, int caixa, int ano)
        {
            TituloObra = tituloObra;
            Edicao = edicao;
            NomeAutor = nomeAutor;
            Editora = editora;
            Isbn = isbn;
            QuantidadeExemplares = quantidadeExemplares;
            Caixa = caixa;
            Ano = ano;
        }
        public string MostrarLivros()
        {
            return "Livro: " + TituloObra;
        }


        public override string ToString()
        {
            return
                     "Titulo da Obra: " + TituloObra + "\n" + 
                    "Edicao: " + Edicao + "\n" +
                    "Editora: " + Editora + "\n" +
                    "ISBN: " + Isbn + "\n" +
                    "Quantidade de Exemplares: " + QuantidadeExemplares + "\n" +
                    "Caixa: " + Caixa + "\n" +
                    "Ano: " + Editora + "\n ";
        }
    }
}
