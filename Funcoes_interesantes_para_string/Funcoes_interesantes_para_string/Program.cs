using System;

namespace Funcoes_interesantes_para_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde ABCDE ABC abc DEFG   ";
            
            
            //maisculo ToUpper()
            string s1 = original.ToUpper();
            //minusculo ToLower()
            string s2 = original.ToLower();
            //Apaga os espaco em branco
            string s3 = original.Trim();
            //Procurando dentro da string o local
            int n1 = original.IndexOf("bc");
            //LastInfexOf
            int n2 = original.LastIndexOf("bc");
            //recortando string Substring
            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);
            //substitui algum caractere
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            //string vazia V/F
            bool b1 = String.IsNullOrEmpty(original);
            //verifica espacos em branco
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine(original);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine("IndexOf(bc):"+n1);
            Console.WriteLine("LastIndexOf(bc):"+n2);
            Console.WriteLine("SubString(3)"+ s4);
            Console.WriteLine("SubString(3,5)" + s5);
            Console.WriteLine(s6);
            Console.WriteLine( s7 );
            Console.WriteLine("IsNullOrEmpty:" +b1);
            Console.WriteLine("IsNullOrWhiteSpace:" +b2);



        }
    }
}
