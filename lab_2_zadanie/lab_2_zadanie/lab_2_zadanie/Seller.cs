using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {
            base.Name = name;   
            base.Age = age; 
        }

        public override string ToString() => $"\tSeller: {Name} ({Age} y.o.)";
    }
}
