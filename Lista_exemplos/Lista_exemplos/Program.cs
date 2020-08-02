using System;
using System.Collections.Generic;
namespace Lista_exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(1, "Joao");
            
            //Mostrar a lista toda
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Mostar o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //List.Find
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);
            // List.FindLast
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //Find Index
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A'" + pos1);
            // Find Last Index
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A'" + pos2);

            //Filtrar lista FindAll
            Console.WriteLine("-----------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //Remover elementos da lista
            Console.WriteLine("______________");
            list.Remove("Alex");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            //RemoveAll
            Console.WriteLine("___________");
            list.RemoveAll(x => x[0] == 'M');
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            //RemoveAt
            Console.WriteLine("______________");
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //RemoveRanve
            Console.WriteLine("______________");
            list.RemoveRange(2,2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
