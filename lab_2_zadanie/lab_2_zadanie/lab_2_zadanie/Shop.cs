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

            for (int i = 0; i < people.Length; i++)
            {
                var a = people[i].ToString().Split(" ");
                if (a[0] == "Seller:")
                {
                    people[i].Print("Seller");
                }
                else if (a[0] == "Buyer:")
                {
                    people[i].Print("Buyer");
                }
            }

            Console.WriteLine("-- Products: --");
            foreach (var e in products)
            {
                Console.WriteLine($"\t{e}");
            }
        }
    }
}
