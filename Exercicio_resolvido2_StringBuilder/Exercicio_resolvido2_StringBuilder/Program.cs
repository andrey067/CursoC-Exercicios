using System;
using Exercicio_resolvido2_StringBuilder.Entities;
namespace Exercicio_resolvido2_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("wow that's awesome!!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:5"),
                "Traveling to New Zeland",
                "I'm go to visit this wonderful country",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);



            Comment c3 = new Comment("Have a nice trip");
            Comment c4 = new Comment("wow that's awesome!!");
            Post p2 = new Post(
                DateTime.Parse("21/06/2018 13:05:5"),
                "Traveling to New Zeland",
                "I'm go to visit this wonderful country",
                12
                );
            p2.AddComment(c3);
            p2.AddComment(c4);


            Comment c5 = new Comment("Have a nice trip");
            Comment c6 = new Comment("wow that's awesome!!");
            Post p3 = new Post(
                DateTime.Parse("21/06/2018 13:05:5"),
                "Traveling to New Zeland",
                "I'm go to visit this wonderful country",
                12
                );
            p3.AddComment(c5);
            p3.AddComment(c6);



            Comment c7 = new Comment("Have a nice trip");
            Comment c8 = new Comment("wow that's awesome!!");
            Post p4 = new Post(
                DateTime.Parse("21/06/2018 13:05:5"),
                "Traveling to New Zeland",
                "I'm go to visit this wonderful country",
                12
                );
            p4.AddComment(c7);
            p4.AddComment(c8);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

        }
    }
}
