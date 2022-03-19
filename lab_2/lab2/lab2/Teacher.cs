using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Teacher : Person
    {
        Teacher(string name, int age) : base(name, age) { }

        public override string ToString() => base.ToString();        
    }
}
