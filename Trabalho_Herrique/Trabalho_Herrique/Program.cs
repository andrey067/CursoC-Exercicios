using System;
using System.Collections.Generic;

namespace Trabalho_Herrique
{
    class Program
    {
        static int opcao = 0;
        static List<Catalogo> Caixa1 = new List<Catalogo>();
        static List<Catalogo> Caixa2 = new List<Catalogo>();
        static List<Catalogo> Caixa3 = new List<Catalogo>();

        static void Main(string[] args)
        {
            Catalogo Titulo1 = new Catalogo("Tetes1", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo2 = new Catalogo("Tetes2", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo3 = new Catalogo("Tetes3", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo4 = new Catalogo("Tetes4", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo5 = new Catalogo("Tetes5", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Caixa1.Add(Titulo1);
            Caixa1.Add(Titulo2);
            Caixa1.Add(Titulo3);
            Caixa1.Add(Titulo4);
            Caixa1.Add(Titulo5);

            Catalogo Titulo6 = new Catalogo("Tetes1", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo7 = new Catalogo("Tetes2", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo8 = new Catalogo("Tetes3", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo9 = new Catalogo("Tetes4", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo10 = new Catalogo("Tetes5", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Caixa2.Add(Titulo6);
            Caixa2.Add(Titulo7);
            Caixa2.Add(Titulo8);
            Caixa2.Add(Titulo9);
            Caixa2.Add(Titulo10);

            Catalogo Titulo11 = new Catalogo("Tetes1", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo12 = new Catalogo("Tetes2", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo13 = new Catalogo("Tetes3", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo14 = new Catalogo("Tetes4", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Catalogo Titulo15 = new Catalogo("Tetes5", "Teste", "Henrique", "Testando", 12345, 2, 1, 2020);
            Caixa3.Add(Titulo11);
            Caixa3.Add(Titulo12);
            Caixa3.Add(Titulo13);
            Caixa3.Add(Titulo14);
            Caixa3.Add(Titulo15);
            //Fim da carga de dados
            
            do
            {
                Console.WriteLine("Bem vindo");
                Console.WriteLine("Cb Henrrique-RA-Curso");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Digite 1 para incluir novo registro das obras");
                Console.WriteLine("Digite 2 para Listar todos os livros");
                Console.WriteLine("Digite 3 para todas as revistas");
                Console.WriteLine("Digite 4 para Listar por caixa");
                Console.WriteLine("Digite 5 para Sair");
                Console.WriteLine("----------------------------------------");
                
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        
                        // Cadastro
                        Console.WriteLine("Digite o Titulo da Obra");
                        string tituloObra = Console.ReadLine();
                        Console.WriteLine("Digite a Edicao");
                        string edicao = Console.ReadLine();
                        Console.WriteLine("Digite o nome do Autor");
                        string nomeAutor = Console.ReadLine();
                        Console.WriteLine("Digite o nome da Editora");
                        string editora = Console.ReadLine();
                        Console.WriteLine("Digite o codigo do livro na ISBN");
                        int isbn = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a quantidade existente da obra");
                        int quantidadeExemplares = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a caixa a onde a obra esta armazenada");

                        int caixa = int.Parse(Console.ReadLine());
                        while (caixa > 3)
                        {
                            Console.WriteLine("Caixa nao existe");
                            caixa = int.Parse(Console.ReadLine());

                        }
                        Console.WriteLine("Digite o Ano");
                        int ano = int.Parse(Console.ReadLine());
                        
                        
                        //Armazenamento do Catalogo
                        if (caixa == 1)
                        {
                            Catalogo Titulo = new Catalogo(tituloObra, edicao, nomeAutor, editora, isbn, quantidadeExemplares, caixa, ano);
                            Caixa1.Add(Titulo);
                            Console.WriteLine("Adicionado na caixa 1");
                        }
                        if (caixa == 2)
                        {
                            Catalogo Titulo = new Catalogo(tituloObra, edicao, nomeAutor, editora, isbn, quantidadeExemplares, caixa, ano);
                            Caixa2.Add(Titulo);
                            Console.WriteLine("Adicionado na caixa 2");

                        }
                        else
                        {
                            Catalogo Titulo = new Catalogo(tituloObra, edicao, nomeAutor, editora, isbn, quantidadeExemplares, caixa, ano);
                            Caixa3.Add(Titulo);
                            Console.WriteLine("Adicionado na caixa 3");

                        }

                        //Fim do Cadastro
                        break;

                    case 2:
                        Console.WriteLine("Caixa 1");
                        foreach (Catalogo caixa1 in Caixa1)
                        {
                            Console.WriteLine("_____________");
                            Console.WriteLine(caixa1.MostrarLivros());
                        }
                        Console.WriteLine("Caixa 2");
                        foreach (Catalogo caixa2 in Caixa2)
                        {
                            Console.WriteLine("_____________");
                            Console.WriteLine(caixa2.MostrarLivros());
                        }
                        Console.WriteLine("Caixa 3");
                        foreach (Catalogo caixa3 in Caixa3)
                        {
                            Console.WriteLine("_____________");
                            Console.WriteLine(caixa3.MostrarLivros());
                        }
                        break;

                    case 3:


                        break;

                    case 4:
                        //Mostrando Catalodo da caixa 1
                        Console.WriteLine("Caixa 1");
                        foreach (Catalogo obj in Caixa1)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine(obj.ToString());
                            Console.WriteLine("_________________________");

                        }
                        //Mostrando Catalogo da caixa 2
                        Console.WriteLine("Caixa 2");
                        foreach (Catalogo obj in Caixa2)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine(obj.ToString());
                            Console.WriteLine("_________________________");

                        }
                        //Mostrando Catalogo da caixa 3
                        Console.WriteLine("Caixa 3");
                        foreach (Catalogo obj in Caixa3)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine(obj.ToString());
                            Console.WriteLine("_________________________");

                        }
                        break;

                }

            } while (opcao <= 4);



        }
    }
}

