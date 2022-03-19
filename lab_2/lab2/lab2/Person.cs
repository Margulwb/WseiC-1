using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string name;
        protected int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public override string ToString() => $"{name}: {age}";

        public bool Equals(Person a)
        {
            if (a.name == name && a.age == age)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
