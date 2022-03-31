using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Fruit : Product
    {
        private int count;
        public int Count { get;set; }

        public Fruit(string name , int count) : base(name)
        {
            this.count = count;
            base.Name = name;
        }
        void Print(string prefix) => Console.WriteLine($"{prefix}");

        public override string ToString() => $"{Name} ({count} {(count >= 1 ? "fruit" : "fruits")})";

    }
}
