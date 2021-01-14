using System;
using Ex_StringBuilder.Entites;
namespace Ex_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            p1.AddCommnet(c1);
            p1.AddCommnet(c2);

            Console.WriteLine(p1.ToString()); 
        }
    }
}
