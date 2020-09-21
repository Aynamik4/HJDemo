using System;

namespace HJDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person meMyself = new Person("Blodgrupp 0")
            {
                Age = 58,
                Name = "Håkan"
            };

            //meMyself.Age = 58;
            //meMyself.Name = "Håkan";

            //Person you = new Person("Blodgrupp 10");

            meMyself.Name = "Håkan";
            //meMyself.SetAge(580);
            //Console.WriteLine(meMyself.Name);
            //Console.WriteLine(meMyself.GetAge());
            meMyself.Age = 58; //Set //int.Parse(Console.ReadLine());
            Console.WriteLine(meMyself.Age); // Get
            int x = meMyself.Age;

            //Cykel minCykel = new Cykel(10, 29.5);
            //minCykel.Color = "Red";
            //minCykel.HasBasket = false;
            //minCykel.HasBell = true;

            //Console.WriteLine(minCykel.Color);
            //Console.WriteLine(minCykel.NumOfGears);

            //minCykel.SizeInInches = 26;
        }
    }
}
