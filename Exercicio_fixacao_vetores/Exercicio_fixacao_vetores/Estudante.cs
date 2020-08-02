using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_vetores
{
    class Estudante
    {
        string Nome { get; set; }
        string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Email:" + Email;
        }



    }
}
