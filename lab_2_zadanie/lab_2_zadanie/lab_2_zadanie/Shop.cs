using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop
    {
        private string name;
        private Person[] people;
        private Product[] products;
        public string Name { get { return name; } set { name = value; } }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;                
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine($"Shop: {Name}\n" + $"-- People: --");

            Console.WriteLine(people[0]);
            for (int i = 1; i < people.Length; i++)
            {
                people[i].Print("Buyer");
                //var a = people[i].ToString();
                //if(a == "Buyer")
                //{
                //    Console.WriteLine("asd");
                //}
            }

            Console.WriteLine("-- Products: --");
            foreach (var e in products)
            {
                Console.WriteLine($"\t{e}");
            }
        }
    }
}
