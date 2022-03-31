using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Meat : Product
    {
        private double weight;
        public double Weight { get { return weight; } set { weight = value; } }

        public Meat(string name, double weight) : base(name)
        {
            Weight = weight;
            base.Name = name;   
        }

        void Print(string prefix) => Console.WriteLine($"{prefix}");

        public override string ToString() => $"{Name} ({Weight} kg)";
    }
}
